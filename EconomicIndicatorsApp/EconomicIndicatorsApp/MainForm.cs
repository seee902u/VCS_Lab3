using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EconomicIndicatorsApp.Implementations;
using System.Data;


namespace EconomicIndicatorsApp
{
    public partial class MainForm : Form
    {
        private List<RoadData> roadDataList; //загруженные данные по дорогам
        private readonly ExcelService _excelService = new ExcelService();
        private readonly InflationDataProvider _dataProvider;
        private readonly MovingAverageForecaster _forecaster;
        private double[] _forecastedInflation;   // Прогнозные годовые темпы инфляции

        public MainForm()
        {
            InitializeComponent();

            // Инициализация ComboBox для выбора субъекта (пока пустой)
            comboSubjectForForecast.DropDownStyle = ComboBoxStyle.DropDownList;

            // Настройка начальных свойств DataGridView
            dgvRoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Путь к файлу с данными относительно папки программы
            string dataPath = Path.Combine(Application.StartupPath, "Data", "inflation_data.xlsx");
            _dataProvider = new InflationDataProvider(dataPath);
            _forecaster = new MovingAverageForecaster();
        }

        //вкладка "ДОРОГИ" 

        private void btnLoadRoads_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            string dataDir = Path.Combine(Application.StartupPath, "Data");
            if (Directory.Exists(dataDir))
                ofd.InitialDirectory = dataDir;
            else
                ofd.InitialDirectory = Application.StartupPath; //на случай если Data нет

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    roadDataList = RoadDataService.LoadFromCsv(ofd.FileName);
                    ShowRoadDataTable();
                    DrawRoadChart();
                    FillSubjectComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки файла: " + ex.Message);
                }
            }
        }

        private void ShowRoadDataTable()
        {
            dgvRoads.DataSource = null;
            // Для удобства сортируем по субъекту и году
            dgvRoads.DataSource = roadDataList
                .OrderBy(d => d.Subject)
                .ThenBy(d => d.Year)
                .ToList();
        }

        private void FillSubjectComboBox()
        {
            comboSubjectForForecast.Items.Clear();
            var subjects = roadDataList.Select(d => d.Subject).Distinct().OrderBy(s => s).ToArray();
            comboSubjectForForecast.Items.AddRange(subjects);
            if (comboSubjectForForecast.Items.Count > 0)
                comboSubjectForForecast.SelectedIndex = 0;
        }

        private void DrawRoadChart()
        {
            chartRoads.Series.Clear();
            var subjects = roadDataList.Select(d => d.Subject).Distinct().OrderBy(s => s);
            // Используем разные цвета для серий (можно задавать вручную или автоматически)
            int i = 0;
            foreach (var subject in subjects)
            {
                var series = new Series(subject)
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2
                };
                var points = roadDataList
                    .Where(d => d.Subject == subject)
                    .OrderBy(d => d.Year);
                foreach (var p in points)
                    series.Points.AddXY(p.Year, p.Percent);
                chartRoads.Series.Add(series);
                i++;
            }
            // Обновляем легенду
            chartRoads.Legends[0].Enabled = true;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (roadDataList == null || roadDataList.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные.");
                return;
            }

            var (maxSubj, maxDec, minSubj, minDec) = RoadDataService.FindMinMaxDecrease(roadDataList);
            string msg = $"Максимальное уменьшение доли плохих дорог:\n" +
                         $"{maxSubj} – изменение {maxDec:+0.0;-0.0} п.п.\n\n" +
                         $"Минимальное уменьшение (наименьшее снижение):\n" +
                         $"{minSubj} – изменение {minDec:+0.0;-0.0} п.п.";
            MessageBox.Show(msg, "Анализ субъектов");
        }

        private void btnPredictRoads_Click(object sender, EventArgs e)
        {
            if (roadDataList == null || comboSubjectForForecast.SelectedItem == null)
            {
                MessageBox.Show("Загрузите данные и выберите субъект.");
                return;
            }
            if (!int.TryParse(txtRoadsN.Text, out int window) || window < 2)
            {
                MessageBox.Show("Введите период сглаживания (целое число >= 2).");
                return;
            }

            string selectedSubject = comboSubjectForForecast.SelectedItem.ToString();
            var subjectData = roadDataList
                .Where(d => d.Subject == selectedSubject)
                .OrderBy(d => d.Year).ToList();

            if (subjectData.Count <= window)
            {
                MessageBox.Show("Недостаточно данных для выбранного периода сглаживания.");
                return;
            }

            List<double> values = subjectData.Select(d => d.Percent).ToList();
            int lastYear = subjectData.Last().Year;
            int forecastHorizon = window; //прогнозируем на столько же лет, сколько и окно 

            List<double> forecast = RoadDataService.MovingAverageForecast(values, window, forecastHorizon);

            //Добавляем на график новую серию с прогнозом
            string seriesName = $"Прогноз ({selectedSubject})";
            var existing = chartRoads.Series.FindByName(seriesName);
            if (existing != null)
                chartRoads.Series.Remove(existing);

            Series forecastSeries = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line,
                BorderDashStyle = ChartDashStyle.Dash,
                Color = Color.Red,
                BorderWidth = 3
            };
            for (int i = 0; i < forecast.Count; i++)
            {
                int year = lastYear + i + 1;
                forecastSeries.Points.AddXY(year, forecast[i]);
            }
            chartRoads.Series.Add(forecastSeries);
        }

        private void btnExportChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chartRoads.SaveImage(sfd.FileName, ChartImageFormat.Png);
                MessageBox.Show("График сохранён.");
            }
        }

        private void btnResetZoom_Click(object sender, EventArgs e)
        {
            chartRoads.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chartRoads.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        //вкладка "ИНФЛЯЦИЯ"
        private void btnLoadInflation_Click(object sender, EventArgs e)
        {
            try
            {
                string relativePath = @"Data\inflation_data.xlsx";
                string fullPath = Path.Combine(Application.StartupPath, relativePath);

                if (!File.Exists(fullPath))
                {
                    MessageBox.Show($"Файл не найден: {fullPath}");
                    return;
                }

                DataTable dt = _excelService.ReadFirstSheet(fullPath);
                dgvInf.DataSource = dt;

                // Построение графика
                double[] history = _dataProvider.ReadInflationRates();
                UpdateChart(history);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

        }

        private void btnPredictInflation_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtInflationN.Text, out int N) || N <= 0)
            {
                MessageBox.Show("Введите положительное целое число лет.");
                return;
            }

            try
            {
                // Получение данных
                double[] history = _dataProvider.ReadInflationRates();

                // Расчёт прогноза
                _forecastedInflation = _forecaster.Forecast(history, N, windowSize: 3);

                // Обновление графика
                UpdateChart(history, _forecastedInflation);

                // Пересчёт будущей цены для текущего значения NumericUpDown
                UpdateFuturePrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg)|*.jpg|Bitmap (*.bmp)|*.bmp|EMF (*.emf)|*.emf|TIFF (*.tiff)|*.tiff|GIF (*.gif)|*.gif";
                sfd.FilterIndex = 1;
                sfd.FileName = "График_инфляции";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Определение формата по выбранному расширению
                    ChartImageFormat format = ChartImageFormat.Png; // по умолчанию
                    string ext = Path.GetExtension(sfd.FileName).ToLower();
                    switch (ext)
                    {
                        case ".jpg":
                        case ".jpeg": format = ChartImageFormat.Jpeg; break;
                        case ".bmp": format = ChartImageFormat.Bmp; break;
                        case ".emf": format = ChartImageFormat.Emf; break;
                        case ".tiff": format = ChartImageFormat.Tiff; break;
                        case ".gif": format = ChartImageFormat.Gif; break;
                        default: format = ChartImageFormat.Png; break;
                    }

                    Chart1.SaveImage(sfd.FileName, format);
                    MessageBox.Show("График сохранён.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Отрисовка графика
        private void UpdateChart(double[] history, double[] forecast = null)
        {
            Chart1.Series.Clear();

            var area = Chart1.ChartAreas[0];
            area.AxisX.Title = "Год";
            area.AxisY.Title = "Инфляция, %";

            // Масштабирование по X и Y
            area.AxisX.ScaleView.Zoomable = true;
            area.AxisY.ScaleView.Zoomable = true;

            // Полоса прокрутки при увеличении
            area.AxisX.ScrollBar.IsPositionedInside = true;
            area.AxisX.ScrollBar.Size = 15;

            // Курсор для выделения мышью
            area.CursorX.IsUserEnabled = true;
            area.CursorX.IsUserSelectionEnabled = true;
            area.CursorX.SelectionColor = Color.LightGray;

            area.CursorY.IsUserEnabled = true;
            area.CursorY.IsUserSelectionEnabled = true;
            area.CursorY.SelectionColor = Color.LightGray;

            // Столбцы
            var historySeries = new Series("Годы")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue
            };
            for (int i = 0; i < history.Length; i++)
                historySeries.Points.AddXY(i + 1, history[i]);
            Chart1.Series.Add(historySeries);

            // Прогнозная линия
            if (forecast != null && forecast.Length > 0)
            {
                var forecastSeries = new Series("Прогноз")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.OrangeRed,
                    BorderWidth = 2
                };
                forecastSeries.Points.Add(new DataPoint(history.Length, history.Last()));
                for (int i = 0; i < forecast.Length; i++)
                    forecastSeries.Points.AddXY(history.Length + i + 1, forecast[i]);
                Chart1.Series.Add(forecastSeries);
            }
        }

        // Изменение текущей цены – пересчёт будущей стоимости
        private void CurrentPriceInputBox_ValueChanged(object sender, EventArgs e)
        {
            UpdateFuturePrice();
        }

        // Обновление текста в RichTextBox с будущей ценой
        private void UpdateFuturePrice()
        {
            if (_forecastedInflation == null)
                return;

            double currentPrice = (double)InputCurrentPriceBox.Value;
            double futurePrice = PricePredictor.PredictFuturePrice(currentPrice, _forecastedInflation);
            NewPriceOutputBox.Text = $"Цена через {_forecastedInflation.Length} лет: {futurePrice:F2}";
        }
    }
}