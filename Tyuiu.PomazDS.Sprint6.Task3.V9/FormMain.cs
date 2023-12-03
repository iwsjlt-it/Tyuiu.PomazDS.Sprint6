using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PomazDS.Sprint6.Task3.V9.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { -14, 25, 26, 18, 17 }, { 28, 10, 6, -2, 4 }, { 30, 25, -3, 11, -10 }, { 11, 32, -5, -20, 25 }, { 2, -18, 11, 8, -20 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTaskMatrix_PDS.ColumnCount = matrix.GetLength(0);
                dataGridViewTaskMatrix_PDS.RowCount = matrix.GetLength(1);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {

                        dataGridViewTaskMatrix_PDS.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                    }
                }

            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_PDS_Click(object sender, EventArgs e)
        {

            int[,] sortMatrix = ds.Calculate(matrix);
            try
            {
                dataGridViewResultMatrix_PDS.ColumnCount = sortMatrix.GetLength(0);
                dataGridViewResultMatrix_PDS.RowCount = sortMatrix.GetLength(1);
 
                for (int i = 0; i < sortMatrix.GetLength(0); i++)
                {

                    for (int j = 0; j < sortMatrix.GetLength(1); j++)
                    {

                        dataGridViewResultMatrix_PDS.Rows[i].Cells[j].Value = sortMatrix[i, j].ToString();
                    }
                }

            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Варинт 9 выполнил студент ИИПб-23-2 Помаз Дмитрий Сергеевич", "Информация о студенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
