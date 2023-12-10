using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PomazDS.Sprint6.Task5.V17.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V17.txt";

        private void buttonDone_PDS_Click(object sender, EventArgs e)
        {
            try
            {
                double[] array = ds.LoadFromDataFile(path);

                int startValue = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    dataGridViewResult_PDS.Rows.Add(startValue.ToString(), array[i].ToString());
                    chartResult_PDS.Series[0].Points.AddXY(startValue, array[i]);
                    startValue++;
                }

            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonOpenFile_PDS_Click(object sender, EventArgs e)
        {

            string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V17.txt";
            File.ReadAllText(path);

            DialogResult dr = MessageBox.Show("Файл " + path + " Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Варинт 17 выполнил студент ИИПб-23-2 Помаз Дмитрий Сергеевич", "Информация о студенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

