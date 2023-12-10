namespace Tyuiu.PomazDS.Sprint6.Task6.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_PDS = new System.Windows.Forms.Panel();
            this.buttonOpenFile_PDS = new System.Windows.Forms.Button();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.panelTask_PDS = new System.Windows.Forms.Panel();
            this.groupBoxActions_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PDS = new System.Windows.Forms.TextBox();
            this.panelIO_PDS = new System.Windows.Forms.Panel();
            this.splitter_PDS = new System.Windows.Forms.Splitter();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_PDS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxInput_PDS = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_PDS = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_PDS.SuspendLayout();
            this.panelTask_PDS.SuspendLayout();
            this.groupBoxActions_PDS.SuspendLayout();
            this.panelIO_PDS.SuspendLayout();
            this.groupBoxOutput_PDS.SuspendLayout();
            this.groupBoxInput_PDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_PDS
            // 
            this.panelTop_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop_PDS.Controls.Add(this.buttonOpenFile_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonDone_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonHelp_PDS);
            this.panelTop_PDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PDS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PDS.Name = "panelTop_PDS";
            this.panelTop_PDS.Size = new System.Drawing.Size(873, 84);
            this.panelTop_PDS.TabIndex = 0;
            // 
            // buttonOpenFile_PDS
            // 
            this.buttonOpenFile_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile_PDS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenFile_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PDS.Image")));
            this.buttonOpenFile_PDS.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_PDS.Name = "buttonOpenFile_PDS";
            this.buttonOpenFile_PDS.Size = new System.Drawing.Size(89, 79);
            this.buttonOpenFile_PDS.TabIndex = 0;
            this.toolTip_PDS.SetToolTip(this.buttonOpenFile_PDS, "Выберите файл для обработки");
            this.buttonOpenFile_PDS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PDS.Click += new System.EventHandler(this.buttonOpenFile_PDS_Click);
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_PDS.Enabled = false;
            this.buttonDone_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PDS.Image")));
            this.buttonDone_PDS.Location = new System.Drawing.Point(98, 3);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(89, 79);
            this.buttonDone_PDS.TabIndex = 0;
            this.toolTip_PDS.SetToolTip(this.buttonDone_PDS, "Выполнить обработку файла\r\n");
            this.buttonDone_PDS.UseVisualStyleBackColor = false;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_PDS.Image")));
            this.buttonHelp_PDS.Location = new System.Drawing.Point(781, 3);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(89, 79);
            this.buttonHelp_PDS.TabIndex = 0;
            this.toolTip_PDS.SetToolTip(this.buttonHelp_PDS, "Справочная информация о студенте");
            this.buttonHelp_PDS.UseVisualStyleBackColor = false;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // panelTask_PDS
            // 
            this.panelTask_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_PDS.Controls.Add(this.groupBoxActions_PDS);
            this.panelTask_PDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PDS.Location = new System.Drawing.Point(0, 84);
            this.panelTask_PDS.Name = "panelTask_PDS";
            this.panelTask_PDS.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_PDS.Size = new System.Drawing.Size(873, 76);
            this.panelTask_PDS.TabIndex = 0;
            // 
            // groupBoxActions_PDS
            // 
            this.groupBoxActions_PDS.Controls.Add(this.textBoxTask_PDS);
            this.groupBoxActions_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActions_PDS.Location = new System.Drawing.Point(5, 5);
            this.groupBoxActions_PDS.Name = "groupBoxActions_PDS";
            this.groupBoxActions_PDS.Size = new System.Drawing.Size(863, 66);
            this.groupBoxActions_PDS.TabIndex = 1;
            this.groupBoxActions_PDS.TabStop = false;
            this.groupBoxActions_PDS.Text = "Условие:";
            // 
            // textBoxTask_PDS
            // 
            this.textBoxTask_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_PDS.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_PDS.Multiline = true;
            this.textBoxTask_PDS.Name = "textBoxTask_PDS";
            this.textBoxTask_PDS.ReadOnly = true;
            this.textBoxTask_PDS.Size = new System.Drawing.Size(857, 47);
            this.textBoxTask_PDS.TabIndex = 0;
            this.textBoxTask_PDS.Text = resources.GetString("textBoxTask_PDS.Text");
            // 
            // panelIO_PDS
            // 
            this.panelIO_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.panelIO_PDS.Controls.Add(this.splitter_PDS);
            this.panelIO_PDS.Controls.Add(this.groupBoxOutput_PDS);
            this.panelIO_PDS.Controls.Add(this.groupBoxInput_PDS);
            this.panelIO_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIO_PDS.Location = new System.Drawing.Point(0, 160);
            this.panelIO_PDS.Name = "panelIO_PDS";
            this.panelIO_PDS.Size = new System.Drawing.Size(873, 371);
            this.panelIO_PDS.TabIndex = 0;
            // 
            // splitter_PDS
            // 
            this.splitter_PDS.Location = new System.Drawing.Point(463, 0);
            this.splitter_PDS.Name = "splitter_PDS";
            this.splitter_PDS.Size = new System.Drawing.Size(3, 371);
            this.splitter_PDS.TabIndex = 2;
            this.splitter_PDS.TabStop = false;
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOutput_PDS.Controls.Add(this.textBoxOutput_PDS);
            this.groupBoxOutput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(463, 0);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(410, 371);
            this.groupBoxOutput_PDS.TabIndex = 1;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод";
            // 
            // textBoxOutput_PDS
            // 
            this.textBoxOutput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_PDS.Location = new System.Drawing.Point(3, 28);
            this.textBoxOutput_PDS.Multiline = true;
            this.textBoxOutput_PDS.Name = "textBoxOutput_PDS";
            this.textBoxOutput_PDS.ReadOnly = true;
            this.textBoxOutput_PDS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_PDS.Size = new System.Drawing.Size(404, 340);
            this.textBoxOutput_PDS.TabIndex = 0;
            // 
            // groupBoxInput_PDS
            // 
            this.groupBoxInput_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInput_PDS);
            this.groupBoxInput_PDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput_PDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_PDS.Name = "groupBoxInput_PDS";
            this.groupBoxInput_PDS.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupBoxInput_PDS.Size = new System.Drawing.Size(463, 371);
            this.groupBoxInput_PDS.TabIndex = 1;
            this.groupBoxInput_PDS.TabStop = false;
            this.groupBoxInput_PDS.Text = "Ввод :";
            // 
            // textBoxInput_PDS
            // 
            this.textBoxInput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_PDS.Location = new System.Drawing.Point(3, 28);
            this.textBoxInput_PDS.Multiline = true;
            this.textBoxInput_PDS.Name = "textBoxInput_PDS";
            this.textBoxInput_PDS.ReadOnly = true;
            this.textBoxInput_PDS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_PDS.Size = new System.Drawing.Size(457, 340);
            this.textBoxInput_PDS.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask_PDS";
            // 
            // toolTip_PDS
            // 
            this.toolTip_PDS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_PDS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 531);
            this.Controls.Add(this.panelIO_PDS);
            this.Controls.Add(this.panelTask_PDS);
            this.Controls.Add(this.panelTop_PDS);
            this.MinimumSize = new System.Drawing.Size(889, 570);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таск 6 Варинт 13 выполнил студент ИИПб-23-2 Помаз Дмитрий Сергеевич";
            this.panelTop_PDS.ResumeLayout(false);
            this.panelTask_PDS.ResumeLayout(false);
            this.groupBoxActions_PDS.ResumeLayout(false);
            this.groupBoxActions_PDS.PerformLayout();
            this.panelIO_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.PerformLayout();
            this.groupBoxInput_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PDS;
        private System.Windows.Forms.Panel panelTask_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.GroupBox groupBoxActions_PDS;
        private System.Windows.Forms.TextBox textBoxTask_PDS;
        private System.Windows.Forms.Panel panelIO_PDS;
        private System.Windows.Forms.Button buttonOpenFile_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.GroupBox groupBoxInput_PDS;
        private System.Windows.Forms.Splitter splitter_PDS;
        private System.Windows.Forms.TextBox textBoxOutput_PDS;
        private System.Windows.Forms.TextBox textBoxInput_PDS;
    }
}

