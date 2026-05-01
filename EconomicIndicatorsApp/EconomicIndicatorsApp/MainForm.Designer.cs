namespace EconomicIndicatorsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInflation = new System.Windows.Forms.TabPage();
            this.btnPredictInflation = new System.Windows.Forms.Button();
            this.txtInflationN = new System.Windows.Forms.TextBox();
            this.lblInflationN = new System.Windows.Forms.Label();
            this.lblInflationTable = new System.Windows.Forms.Label();
            this.btnLoadInflation = new System.Windows.Forms.Button();
            this.tabRoads = new System.Windows.Forms.TabPage();
            this.btnPredictRoads = new System.Windows.Forms.Button();
            this.txtRoadsN = new System.Windows.Forms.TextBox();
            this.lblRoadsN = new System.Windows.Forms.Label();
            this.btnLoadRoads = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSubjectForForecast = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnExportChart = new System.Windows.Forms.Button();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.dgvRoads = new System.Windows.Forms.DataGridView();
            this.chartRoads = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabInflation.SuspendLayout();
            this.tabRoads.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoads)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInflation);
            this.tabControl1.Controls.Add(this.tabRoads);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 762);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInflation
            // 
            this.tabInflation.Controls.Add(this.btnPredictInflation);
            this.tabInflation.Controls.Add(this.txtInflationN);
            this.tabInflation.Controls.Add(this.lblInflationN);
            this.tabInflation.Controls.Add(this.lblInflationTable);
            this.tabInflation.Controls.Add(this.btnLoadInflation);
            this.tabInflation.Location = new System.Drawing.Point(4, 29);
            this.tabInflation.Name = "tabInflation";
            this.tabInflation.Padding = new System.Windows.Forms.Padding(3);
            this.tabInflation.Size = new System.Drawing.Size(920, 561);
            this.tabInflation.TabIndex = 0;
            this.tabInflation.Text = "Инфляция";
            this.tabInflation.UseVisualStyleBackColor = true;
            // 
            // btnPredictInflation
            // 
            this.btnPredictInflation.Location = new System.Drawing.Point(255, 59);
            this.btnPredictInflation.Name = "btnPredictInflation";
            this.btnPredictInflation.Size = new System.Drawing.Size(194, 85);
            this.btnPredictInflation.TabIndex = 5;
            this.btnPredictInflation.Text = "Рассчитать прогноз и стоимость товара";
            this.btnPredictInflation.UseVisualStyleBackColor = true;
            this.btnPredictInflation.Click += new System.EventHandler(this.btnPredictInflation_Click);
            // 
            // txtInflationN
            // 
            this.txtInflationN.Location = new System.Drawing.Point(229, 175);
            this.txtInflationN.Name = "txtInflationN";
            this.txtInflationN.Size = new System.Drawing.Size(220, 26);
            this.txtInflationN.TabIndex = 4;
            // 
            // lblInflationN
            // 
            this.lblInflationN.AutoSize = true;
            this.lblInflationN.Location = new System.Drawing.Point(35, 175);
            this.lblInflationN.Name = "lblInflationN";
            this.lblInflationN.Size = new System.Drawing.Size(187, 20);
            this.lblInflationN.TabIndex = 3;
            this.lblInflationN.Text = "Период прогноза (лет):";
            // 
            // lblInflationTable
            // 
            this.lblInflationTable.AutoSize = true;
            this.lblInflationTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInflationTable.Location = new System.Drawing.Point(30, 249);
            this.lblInflationTable.Name = "lblInflationTable";
            this.lblInflationTable.Size = new System.Drawing.Size(574, 29);
            this.lblInflationTable.TabIndex = 2;
            this.lblInflationTable.Text = "Таблица и данные появятся после загрузки ";
            // 
            // btnLoadInflation
            // 
            this.btnLoadInflation.Location = new System.Drawing.Point(35, 59);
            this.btnLoadInflation.Name = "btnLoadInflation";
            this.btnLoadInflation.Size = new System.Drawing.Size(200, 85);
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
            this.tabRoads.Location = new System.Drawing.Point(4, 29);
            this.tabRoads.Name = "tabRoads";
            this.tabRoads.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoads.Size = new System.Drawing.Size(969, 729);
            this.tabRoads.TabIndex = 1;
            this.tabRoads.Text = "Доля плохих дорог";
            this.tabRoads.UseVisualStyleBackColor = true;
            // 
            // btnPredictRoads
            // 
            this.btnPredictRoads.Location = new System.Drawing.Point(235, 21);
            this.btnPredictRoads.Name = "btnPredictRoads";
            this.btnPredictRoads.Size = new System.Drawing.Size(147, 80);
            this.btnPredictRoads.TabIndex = 4;
            this.btnPredictRoads.Text = "Рассчитать прогноз";
            this.btnPredictRoads.UseVisualStyleBackColor = true;
            this.btnPredictRoads.Click += new System.EventHandler(this.btnPredictRoads_Click);
            // 
            // txtRoadsN
            // 
            this.txtRoadsN.Location = new System.Drawing.Point(235, 114);
            this.txtRoadsN.Name = "txtRoadsN";
            this.txtRoadsN.Size = new System.Drawing.Size(147, 26);
            this.txtRoadsN.TabIndex = 3;
            // 
            // lblRoadsN
            // 
            this.lblRoadsN.AutoSize = true;
            this.lblRoadsN.Location = new System.Drawing.Point(12, 117);
            this.lblRoadsN.Name = "lblRoadsN";
            this.lblRoadsN.Size = new System.Drawing.Size(217, 20);
            this.lblRoadsN.TabIndex = 2;
            this.lblRoadsN.Text = "Период сглаживания (лет):";
            // 
            // btnLoadRoads
            // 
            this.btnLoadRoads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadRoads.Location = new System.Drawing.Point(16, 21);
            this.btnLoadRoads.Name = "btnLoadRoads";
            this.btnLoadRoads.Size = new System.Drawing.Size(213, 80);
            this.btnLoadRoads.TabIndex = 0;
            this.btnLoadRoads.Text = "Загрузить данные о дорогах";
            this.btnLoadRoads.UseVisualStyleBackColor = true;
            this.btnLoadRoads.Click += new System.EventHandler(this.btnLoadRoads_Click);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 150);
            this.panel1.TabIndex = 5;
            // 
            // comboSubjectForForecast
            // 
            this.comboSubjectForForecast.FormattingEnabled = true;
            this.comboSubjectForForecast.Location = new System.Drawing.Point(602, 114);
            this.comboSubjectForForecast.Name = "comboSubjectForForecast";
            this.comboSubjectForForecast.Size = new System.Drawing.Size(180, 28);
            this.comboSubjectForForecast.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(412, 120);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(184, 20);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Субъект для прогноза:";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(416, 21);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(180, 80);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Анализ субъектов ";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnExportChart
            // 
            this.btnExportChart.Location = new System.Drawing.Point(602, 21);
            this.btnExportChart.Name = "btnExportChart";
            this.btnExportChart.Size = new System.Drawing.Size(180, 80);
            this.btnExportChart.TabIndex = 8;
            this.btnExportChart.Text = "Экспорт графика";
            this.btnExportChart.UseVisualStyleBackColor = true;
            this.btnExportChart.Click += new System.EventHandler(this.btnExportChart_Click);
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Location = new System.Drawing.Point(807, 21);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(118, 116);
            this.btnResetZoom.TabIndex = 9;
            this.btnResetZoom.Text = "Сброс масштаба";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.Click += new System.EventHandler(this.btnResetZoom_Click);
            // 
            // dgvRoads
            // 
            this.dgvRoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoads.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRoads.Location = new System.Drawing.Point(3, 153);
            this.dgvRoads.Name = "dgvRoads";
            this.dgvRoads.RowHeadersWidth = 62;
            this.dgvRoads.RowTemplate.Height = 28;
            this.dgvRoads.Size = new System.Drawing.Size(963, 234);
            this.dgvRoads.TabIndex = 6;
            // 
            // chartRoads
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Title = "Год";
            chartArea2.AxisY.Title = "% плохих дорог";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chartRoads.ChartAreas.Add(chartArea2);
            this.chartRoads.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chartRoads.Legends.Add(legend2);
            this.chartRoads.Location = new System.Drawing.Point(3, 387);
            this.chartRoads.Name = "chartRoads";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRoads.Series.Add(series2);
            this.chartRoads.Size = new System.Drawing.Size(963, 342);
            this.chartRoads.TabIndex = 7;
            this.chartRoads.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 762);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Анализ социально-экономических показателей России";
            this.tabControl1.ResumeLayout(false);
            this.tabInflation.ResumeLayout(false);
            this.tabInflation.PerformLayout();
            this.tabRoads.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoads)).EndInit();
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
        private System.Windows.Forms.Label lblInflationTable;
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
    }
}

