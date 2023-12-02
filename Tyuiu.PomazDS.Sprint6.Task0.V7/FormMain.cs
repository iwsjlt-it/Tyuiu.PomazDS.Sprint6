using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PomazDS.Sprint6.Task0.V7.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.PomazDS.Sprint6.Task0.V7
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
                int x = 3;
                textBoxOutput_PDS.Text = ds.Calculate(x).ToString();
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Варинт 7 выполнил студент ИИПб-23-2 Помаз Дмитрий Сергеевич","Информация о студенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
