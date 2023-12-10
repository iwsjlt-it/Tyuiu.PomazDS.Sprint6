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

using Tyuiu.PomazDS.Sprint6.Task6.V13.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath = null;
        private void buttonOpenFile_PDS_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput_PDS.Text = File.ReadAllText(openFilePath);
            groupBoxInput_PDS.Text = groupBoxInput_PDS.Text + " " + openFileDialogTask.FileName;
            buttonDone_PDS.Enabled = true;
        }

        private void buttonDone_PDS_Click(object sender, EventArgs e)
        {
            textBoxOutput_PDS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_PDS_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

    }
}
