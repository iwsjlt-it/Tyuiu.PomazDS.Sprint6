using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PomazDS.Sprint6.Task1.V2.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task1.V2
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

                string str = null;
                textBoxOutput_PDS.AppendText("+-----------+------------+" + "\r\n"); 
                textBoxOutput_PDS.AppendText("|     X     |    f(x)    |" + "\r\n");
                textBoxOutput_PDS.AppendText("+-----------+------------+" + "\r\n");
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    str = string.Format("|{0,6}     |  {1, 6}    |", startValue, array[i]);
                    textBoxOutput_PDS.AppendText(str + "\r\n");
                    startValue++;
                }
                textBoxOutput_PDS.AppendText("+-----------+------------+" + "\r\n");
            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Варинт 2 выполнил студент ИИПб-23-2 Помаз Дмитрий Сергеевич", "Информация о студенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   
    }
}
