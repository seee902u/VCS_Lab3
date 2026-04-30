using System;
using System.Windows.Forms;

namespace EconomicIndicatorsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Вариант 10: Инфляция 
        private void btnLoadInflation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет загрузка файла с инфляцией (вар. 10)",
                            "Инфляция");
        }

        private void btnPredictInflation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет прогноз инфляции и расчёт стоимости товара",
                            "Прогноз");
        }

        //Вариант 16: Доля плохих дорог 
        private void btnLoadRoads_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет загрузка файла с данными о дорогах (вар. 16)",
                            "Дороги");
        }

        private void btnPredictRoads_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет прогноз доли плохих дорог и анализ субъектов",
                            "Прогноз");
        }
    }
}