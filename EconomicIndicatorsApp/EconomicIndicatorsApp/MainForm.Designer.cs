namespace EconomicIndicatorsApp
{
    partial class MainForm
    {
        
        /// Обязательная переменная конструктора.
        private System.ComponentModel.IContainer components = null;

        /// Освободить все используемые ресурсы.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInflation = new System.Windows.Forms.TabPage();
            this.btnPredictInflation = new System.Windows.Forms.Button();
            this.txtInflationN = new System.Windows.Forms.TextBox();
            this.lblInflationN = new System.Windows.Forms.Label();
            this.btnLoadInflation = new System.Windows.Forms.Button();
            this.tabRoads = new System.Windows.Forms.TabPage();
            this.chartRoads = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvRoads = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.btnExportChart = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.comboSubjectForForecast = new System.Windows.Forms.ComboBox();
            this.btnLoadRoads = new System.Windows.Forms.Button();
            this.btnPredictRoads = new System.Windows.Forms.Button();
            this.lblRoadsN = new System.Windows.Forms.Label();
            this.txtRoadsN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputCurrentPriceBox = new System.Windows.Forms.NumericUpDown();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NewPriceOutputBox = new System.Windows.Forms.RichTextBox();
            this.dgvInf = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInflation.SuspendLayout();
            this.tabRoads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoads)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputCurrentPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInf)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInflation);
            this.tabControl1.Controls.Add(this.tabRoads);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInflation
            // 
            this.tabInflation.Controls.Add(this.btnExport);
            this.tabInflation.Controls.Add(this.dgvInf);
            this.tabInflation.Controls.Add(this.NewPriceOutputBox);
            this.tabInflation.Controls.Add(this.Chart1);
            this.tabInflation.Controls.Add(this.InputCurrentPriceBox);
            this.tabInflation.Controls.Add(this.label1);
            this.tabInflation.Controls.Add(this.btnPredictInflation);
            this.tabInflation.Controls.Add(this.txtInflationN);
            this.tabInflation.Controls.Add(this.lblInflationN);
            this.tabInflation.Controls.Add(this.btnLoadInflation);
            this.tabInflation.Location = new System.Drawing.Point(4, 22);
            this.tabInflation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInflation.Name = "tabInflation";
            this.tabInflation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInflation.Size = new System.Drawing.Size(643, 469);
            this.tabInflation.TabIndex = 0;
            this.tabInflation.Text = "Инфляция";
            this.tabInflation.UseVisualStyleBackColor = true;
            // 
            // btnPredictInflation
            // 
            this.btnPredictInflation.Location = new System.Drawing.Point(170, 38);
            this.btnPredictInflation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPredictInflation.Name = "btnPredictInflation";
            this.btnPredictInflation.Size = new System.Drawing.Size(129, 55);
            this.btnPredictInflation.TabIndex = 5;
            this.btnPredictInflation.Text = "Рассчитать прогноз и стоимость товара";
            this.btnPredictInflation.UseVisualStyleBackColor = true;
            this.btnPredictInflation.Click += new System.EventHandler(this.btnPredictInflation_Click);
            // 
            // txtInflationN
            // 
            this.txtInflationN.Location = new System.Drawing.Point(153, 114);
            this.txtInflationN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInflationN.Name = "txtInflationN";
            this.txtInflationN.Size = new System.Drawing.Size(148, 20);
            this.txtInflationN.TabIndex = 4;
            // 
            // lblInflationN
            // 
            this.lblInflationN.AutoSize = true;
            this.lblInflationN.Location = new System.Drawing.Point(23, 114);
            this.lblInflationN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInflationN.Name = "lblInflationN";
            this.lblInflationN.Size = new System.Drawing.Size(124, 13);
            this.lblInflationN.TabIndex = 3;
            this.lblInflationN.Text = "Период прогноза (лет):";
            // 
            // btnLoadInflation
            // 
            this.btnLoadInflation.Location = new System.Drawing.Point(23, 38);
            this.btnLoadInflation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadInflation.Name = "btnLoadInflation";
            this.btnLoadInflation.Size = new System.Drawing.Size(133, 55);
            this.btnLoadInflation.TabIndex = 0;
            this.btnLoadInflation.Text = "Загрузить данные об инфляции";
            this.btnLoadInflation.UseVisualStyleBackColor = true;
            this.btnLoadInflation.Click += new System.EventHandler(this.btnLoadInflation_Click);
            // 
            // tabRoads
            // 
            this.tabRoads.Controls.Add(this.chartRoads);
            this.tabRoads.Controls.Add(this.dgvRoads);
            this.tabRoads.Controls.Add(this.panel1);
            this.tabRoads.Location = new System.Drawing.Point(4, 22);
            this.tabRoads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRoads.Name = "tabRoads";
            this.tabRoads.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRoads.Size = new System.Drawing.Size(643, 469);
            this.tabRoads.TabIndex = 1;
            this.tabRoads.Text = "Доля плохих дорог";
            this.tabRoads.UseVisualStyleBackColor = true;
            // 
            // chartRoads
            // 
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.Title = "Год";
            chartArea4.AxisY.Title = "% плохих дорог";
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorY.IsUserEnabled = true;
            chartArea4.Name = "ChartArea1";
            this.chartRoads.ChartAreas.Add(chartArea4);
            this.chartRoads.Dock = System.Windows.Forms.DockStyle.Top;
            legend4.Name = "Legend1";
            this.chartRoads.Legends.Add(legend4);
            this.chartRoads.Location = new System.Drawing.Point(2, 252);
            this.chartRoads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartRoads.Name = "chartRoads";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRoads.Series.Add(series4);
            this.chartRoads.Size = new System.Drawing.Size(639, 222);
            this.chartRoads.TabIndex = 7;
            this.chartRoads.Text = "chart1";
            // 
            // dgvRoads
            // 
            this.dgvRoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoads.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRoads.Location = new System.Drawing.Point(2, 100);
            this.dgvRoads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoads.Name = "dgvRoads";
            this.dgvRoads.RowHeadersWidth = 62;
            this.dgvRoads.RowTemplate.Height = 28;
            this.dgvRoads.Size = new System.Drawing.Size(639, 152);
            this.dgvRoads.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetZoom);
            this.panel1.Controls.Add(this.btnExportChart);
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.comboSubjectForForecast);
            this.panel1.Controls.Add(this.btnLoadRoads);
            this.panel1.Controls.Add(this.btnPredictRoads);
            this.panel1.Controls.Add(this.lblRoadsN);
            this.panel1.Controls.Add(this.txtRoadsN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 98);
            this.panel1.TabIndex = 5;
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Location = new System.Drawing.Point(538, 14);
            this.btnResetZoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(79, 75);
            this.btnResetZoom.TabIndex = 9;
            this.btnResetZoom.Text = "Сброс масштаба";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.Click += new System.EventHandler(this.btnResetZoom_Click);
            // 
            // btnExportChart
            // 
            this.btnExportChart.Location = new System.Drawing.Point(401, 14);
            this.btnExportChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportChart.Name = "btnExportChart";
            this.btnExportChart.Size = new System.Drawing.Size(120, 52);
            this.btnExportChart.TabIndex = 8;
            this.btnExportChart.Text = "Экспорт графика";
            this.btnExportChart.UseVisualStyleBackColor = true;
            this.btnExportChart.Click += new System.EventHandler(this.btnExportChart_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(277, 14);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(120, 52);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Анализ субъектов ";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(275, 78);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(123, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Субъект для прогноза:";
            // 
            // comboSubjectForForecast
            // 
            this.comboSubjectForForecast.FormattingEnabled = true;
            this.comboSubjectForForecast.Location = new System.Drawing.Point(401, 74);
            this.comboSubjectForForecast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboSubjectForForecast.Name = "comboSubjectForForecast";
            this.comboSubjectForForecast.Size = new System.Drawing.Size(121, 21);
            this.comboSubjectForForecast.TabIndex = 5;
            // 
            // btnLoadRoads
            // 
            this.btnLoadRoads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadRoads.Location = new System.Drawing.Point(11, 14);
            this.btnLoadRoads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadRoads.Name = "btnLoadRoads";
            this.btnLoadRoads.Size = new System.Drawing.Size(142, 52);
            this.btnLoadRoads.TabIndex = 0;
            this.btnLoadRoads.Text = "Загрузить данные о дорогах";
            this.btnLoadRoads.UseVisualStyleBackColor = true;
            this.btnLoadRoads.Click += new System.EventHandler(this.btnLoadRoads_Click);
            // 
            // btnPredictRoads
            // 
            this.btnPredictRoads.Location = new System.Drawing.Point(157, 14);
            this.btnPredictRoads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPredictRoads.Name = "btnPredictRoads";
            this.btnPredictRoads.Size = new System.Drawing.Size(98, 52);
            this.btnPredictRoads.TabIndex = 4;
            this.btnPredictRoads.Text = "Рассчитать прогноз";
            this.btnPredictRoads.UseVisualStyleBackColor = true;
            this.btnPredictRoads.Click += new System.EventHandler(this.btnPredictRoads_Click);
            // 
            // lblRoadsN
            // 
            this.lblRoadsN.AutoSize = true;
            this.lblRoadsN.Location = new System.Drawing.Point(8, 76);
            this.lblRoadsN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoadsN.Name = "lblRoadsN";
            this.lblRoadsN.Size = new System.Drawing.Size(144, 13);
            this.lblRoadsN.TabIndex = 2;
            this.lblRoadsN.Text = "Период сглаживания (лет):";
            // 
            // txtRoadsN
            // 
            this.txtRoadsN.Location = new System.Drawing.Point(157, 74);
            this.txtRoadsN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoadsN.Name = "txtRoadsN";
            this.txtRoadsN.Size = new System.Drawing.Size(99, 20);
            this.txtRoadsN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите текущую цену:";
            // 
            // InputCurrentPriceBox
            // 
            this.InputCurrentPriceBox.Location = new System.Drawing.Point(338, 57);
            this.InputCurrentPriceBox.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.InputCurrentPriceBox.Name = "InputCurrentPriceBox";
            this.InputCurrentPriceBox.Size = new System.Drawing.Size(168, 20);
            this.InputCurrentPriceBox.TabIndex = 7;
            this.InputCurrentPriceBox.ValueChanged += new System.EventHandler(this.CurrentPriceInputBox_ValueChanged);
            // 
            // Chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart1.Legends.Add(legend3);
            this.Chart1.Location = new System.Drawing.Point(321, 149);
            this.Chart1.Name = "Chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(303, 301);
            this.Chart1.TabIndex = 8;
            this.Chart1.Text = "chart1";
            // 
            // NewPriceOutputBox
            // 
            this.NewPriceOutputBox.Location = new System.Drawing.Point(338, 91);
            this.NewPriceOutputBox.Name = "NewPriceOutputBox";
            this.NewPriceOutputBox.Size = new System.Drawing.Size(167, 36);
            this.NewPriceOutputBox.TabIndex = 9;
            this.NewPriceOutputBox.Text = "";
            // 
            // dgvInf
            // 
            this.dgvInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInf.Location = new System.Drawing.Point(24, 155);
            this.dgvInf.Name = "dgvInf";
            this.dgvInf.Size = new System.Drawing.Size(276, 294);
            this.dgvInf.TabIndex = 10;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(535, 46);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 45);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Экспорт графика";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 495);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Анализ социально-экономических показателей России";
            this.tabControl1.ResumeLayout(false);
            this.tabInflation.ResumeLayout(false);
            this.tabInflation.PerformLayout();
            this.tabRoads.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoads)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputCurrentPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInflation;
        private System.Windows.Forms.Button btnLoadInflation;
        private System.Windows.Forms.TabPage tabRoads;
        private System.Windows.Forms.Button btnPredictInflation;
        private System.Windows.Forms.TextBox txtInflationN;
        private System.Windows.Forms.Label lblInflationN;
        private System.Windows.Forms.Button btnLoadRoads;
        private System.Windows.Forms.Button btnPredictRoads;
        private System.Windows.Forms.TextBox txtRoadsN;
        private System.Windows.Forms.Label lblRoadsN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRoads;
        private System.Windows.Forms.Button btnResetZoom;
        private System.Windows.Forms.Button btnExportChart;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox comboSubjectForForecast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRoads;
        private System.Windows.Forms.DataGridView dgvInf;
        private System.Windows.Forms.RichTextBox NewPriceOutputBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.NumericUpDown InputCurrentPriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
    }
}

