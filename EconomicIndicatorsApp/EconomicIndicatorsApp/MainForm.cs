using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EconomicIndicatorsApp
{
    public partial class MainForm : Form
    {
        private List<RoadData> roadDataList; //загруженные данные по дорогам

        public MainForm()
        {
            InitializeComponent();

            // Инициализация ComboBox для выбора субъекта (пока пустой)
            comboSubjectForForecast.DropDownStyle = ComboBoxStyle.DropDownList;

            // Настройка начальных свойств DataGridView
            dgvRoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        //вкладка "ИНФЛЯЦИЯ" (сделает ника)
        private void btnLoadInflation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загрузка инфляции пока не реализована.");
        }

        private void btnPredictInflation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Прогноз инфляции пока не реализован.");
        }
    }
}