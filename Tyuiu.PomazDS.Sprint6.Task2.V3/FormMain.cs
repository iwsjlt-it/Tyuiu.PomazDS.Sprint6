using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PomazDS.Sprint6.Task2.V3.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PDS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = int.Parse(textBoxInputStartValue_PDS.Text);
                int stopValue = int.Parse(textBoxInputStopValue_PDS.Text);

                double[] array = ds.GetMassFunction(startValue, stopValue);

                chartFunction_PDS.Titles.Add("График функции f(x)");
                chartFunction_PDS.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_PDS.ChartAreas[0].AxisY.Title = "Ось Y";
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    dataGridViewFunction_PDS.Rows.Add(startValue.ToString(), array[i].ToString());
                    chartFunction_PDS.Series[0].Points.AddXY(startValue, array[i]);
                    startValue++;
                }
                
            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Варинт 3 выполнил студент ИИПб-23-2 Помаз Дмитрий Сергеевич", "Информация о студенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PDS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PDS.BackColor = Color.Blue;
        }

        private void buttonDone_PDS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PDS.BackColor = Color.Green;
        }

        private void buttonDone_PDS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PDS.BackColor = Color.Pink;
        }
    }
}
