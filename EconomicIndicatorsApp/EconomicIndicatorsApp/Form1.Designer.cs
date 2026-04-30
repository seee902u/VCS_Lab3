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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInflation = new System.Windows.Forms.TabPage();
            this.tabRoads = new System.Windows.Forms.TabPage();
            this.btnLoadInflation = new System.Windows.Forms.Button();
            this.lblInflationTable = new System.Windows.Forms.Label();
            this.lblInflationN = new System.Windows.Forms.Label();
            this.txtInflationN = new System.Windows.Forms.TextBox();
            this.btnPredictInflation = new System.Windows.Forms.Button();
            this.btnLoadRoads = new System.Windows.Forms.Button();
            this.lblRoadsTable = new System.Windows.Forms.Label();
            this.lblRoadsN = new System.Windows.Forms.Label();
            this.txtRoadsN = new System.Windows.Forms.TextBox();
            this.btnPredictRoads = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInflation.SuspendLayout();
            this.tabRoads.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(928, 594);
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
            // tabRoads
            // 
            this.tabRoads.Controls.Add(this.btnPredictRoads);
            this.tabRoads.Controls.Add(this.txtRoadsN);
            this.tabRoads.Controls.Add(this.lblRoadsN);
            this.tabRoads.Controls.Add(this.lblRoadsTable);
            this.tabRoads.Controls.Add(this.btnLoadRoads);
            this.tabRoads.Location = new System.Drawing.Point(4, 29);
            this.tabRoads.Name = "tabRoads";
            this.tabRoads.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoads.Size = new System.Drawing.Size(920, 561);
            this.tabRoads.TabIndex = 1;
            this.tabRoads.Text = "Доля плохих дорог";
            this.tabRoads.UseVisualStyleBackColor = true;
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
            // lblInflationN
            // 
            this.lblInflationN.AutoSize = true;
            this.lblInflationN.Location = new System.Drawing.Point(35, 175);
            this.lblInflationN.Name = "lblInflationN";
            this.lblInflationN.Size = new System.Drawing.Size(187, 20);
            this.lblInflationN.TabIndex = 3;
            this.lblInflationN.Text = "Период прогноза (лет):";
            // 
            // txtInflationN
            // 
            this.txtInflationN.Location = new System.Drawing.Point(229, 175);
            this.txtInflationN.Name = "txtInflationN";
            this.txtInflationN.Size = new System.Drawing.Size(220, 26);
            this.txtInflationN.TabIndex = 4;
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
            // btnLoadRoads
            // 
            this.btnLoadRoads.Location = new System.Drawing.Point(59, 66);
            this.btnLoadRoads.Name = "btnLoadRoads";
            this.btnLoadRoads.Size = new System.Drawing.Size(170, 80);
            this.btnLoadRoads.TabIndex = 0;
            this.btnLoadRoads.Text = "Загрузить данные о дорогах";
            this.btnLoadRoads.UseVisualStyleBackColor = true;
            this.btnLoadRoads.Click += new System.EventHandler(this.btnLoadRoads_Click);
            // 
            // lblRoadsTable
            // 
            this.lblRoadsTable.AutoSize = true;
            this.lblRoadsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoadsTable.Location = new System.Drawing.Point(37, 280);
            this.lblRoadsTable.Name = "lblRoadsTable";
            this.lblRoadsTable.Size = new System.Drawing.Size(562, 29);
            this.lblRoadsTable.TabIndex = 1;
            this.lblRoadsTable.Text = "Таблица и график появятся после загрузки";
            // 
            // lblRoadsN
            // 
            this.lblRoadsN.AutoSize = true;
            this.lblRoadsN.Location = new System.Drawing.Point(42, 201);
            this.lblRoadsN.Name = "lblRoadsN";
            this.lblRoadsN.Size = new System.Drawing.Size(187, 20);
            this.lblRoadsN.TabIndex = 2;
            this.lblRoadsN.Text = "Период прогноза (лет):";
            // 
            // txtRoadsN
            // 
            this.txtRoadsN.Location = new System.Drawing.Point(236, 201);
            this.txtRoadsN.Name = "txtRoadsN";
            this.txtRoadsN.Size = new System.Drawing.Size(239, 26);
            this.txtRoadsN.TabIndex = 3;
            // 
            // btnPredictRoads
            // 
            this.btnPredictRoads.Location = new System.Drawing.Point(267, 66);
            this.btnPredictRoads.Name = "btnPredictRoads";
            this.btnPredictRoads.Size = new System.Drawing.Size(192, 80);
            this.btnPredictRoads.TabIndex = 4;
            this.btnPredictRoads.Text = "Рассчитать прогноз";
            this.btnPredictRoads.UseVisualStyleBackColor = true;
            this.btnPredictRoads.Click += new System.EventHandler(this.btnPredictRoads_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Анализ социально-экономических показателей России";
            this.tabControl1.ResumeLayout(false);
            this.tabInflation.ResumeLayout(false);
            this.tabInflation.PerformLayout();
            this.tabRoads.ResumeLayout(false);
            this.tabRoads.PerformLayout();
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
        private System.Windows.Forms.Label lblRoadsTable;
        private System.Windows.Forms.Button btnLoadRoads;
        private System.Windows.Forms.Button btnPredictRoads;
        private System.Windows.Forms.TextBox txtRoadsN;
        private System.Windows.Forms.Label lblRoadsN;
    }
}

