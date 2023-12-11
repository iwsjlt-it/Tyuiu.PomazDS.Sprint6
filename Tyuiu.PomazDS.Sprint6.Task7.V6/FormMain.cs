using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PomazDS.Sprint6.Task7.V6.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath = null;
        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonSaveFile_PDS_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();



            string path = saveFileDialogTask.FileName;
            string str = null;
            int rows = File.ReadLines(openFilePath).Count();
            int columns = rows;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {

                        str = str + dataGridViewOutput_PDS.Rows[i].Cells[j].Value + ";";
                    }
                    else str = str + dataGridViewOutput_PDS.Rows[i].Cells[j].Value;
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = ""; 
            }
            str = null;
        }

        private void buttonDone_PDS_Click(object sender, EventArgs e)
        {
            int[,] array = ds.GetMatrix(openFilePath);

            dataGridViewOutput_PDS.ColumnCount = array.GetLength(0);
            dataGridViewOutput_PDS.RowCount = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == 6)
                {

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] != 6)
                        {
                            dataGridViewOutput_PDS.Rows[i].Cells[j].Value = "0";
                        }
                        else dataGridViewOutput_PDS.Rows[i].Cells[j].Value = array[i, j].ToString();
                    }
                    continue;
                }
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridViewOutput_PDS.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }

        private void buttonOpenFile_PDS_Click(object sender, EventArgs e)
        {

            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            groupBoxInput_PDS.Text = groupBoxInput_PDS.Text + " " + openFileDialogTask.FileName;
            buttonDone_PDS.Enabled = true;
            buttonSaveFile_PDS.Enabled = true;

            int[,] array = ds.GetMatrix(openFilePath);
            dataGridViewInput_PDS.ColumnCount = array.GetLength(0);
            dataGridViewInput_PDS.RowCount = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridViewInput_PDS.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }

    }
}
