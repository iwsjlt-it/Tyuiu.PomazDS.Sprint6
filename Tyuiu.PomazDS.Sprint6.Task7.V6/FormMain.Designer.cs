namespace Tyuiu.PomazDS.Sprint6.Task7.V6
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
            this.panelActions_PDS = new System.Windows.Forms.Panel();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.buttonSaveFile_PDS = new System.Windows.Forms.Button();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.buttonOpenFile_PDS = new System.Windows.Forms.Button();
            this.panelTask_PDS = new System.Windows.Forms.Panel();
            this.groupBoxTask_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PDS = new System.Windows.Forms.TextBox();
            this.panelIO_PDS = new System.Windows.Forms.Panel();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_PDS = new System.Windows.Forms.DataGridView();
            this.groupBoxInput_PDS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_PDS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelActions_PDS.SuspendLayout();
            this.panelTask_PDS.SuspendLayout();
            this.groupBoxTask_PDS.SuspendLayout();
            this.panelIO_PDS.SuspendLayout();
            this.groupBoxOutput_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PDS)).BeginInit();
            this.groupBoxInput_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActions_PDS
            // 
            this.panelActions_PDS.Controls.Add(this.buttonHelp_PDS);
            this.panelActions_PDS.Controls.Add(this.buttonSaveFile_PDS);
            this.panelActions_PDS.Controls.Add(this.buttonDone_PDS);
            this.panelActions_PDS.Controls.Add(this.buttonOpenFile_PDS);
            this.panelActions_PDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions_PDS.Location = new System.Drawing.Point(0, 0);
            this.panelActions_PDS.Name = "panelActions_PDS";
            this.panelActions_PDS.Size = new System.Drawing.Size(897, 83);
            this.panelActions_PDS.TabIndex = 0;
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_PDS.Image")));
            this.buttonHelp_PDS.Location = new System.Drawing.Point(804, 3);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(90, 77);
            this.buttonHelp_PDS.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonHelp_PDS, "Информация о студенте");
            this.buttonHelp_PDS.UseVisualStyleBackColor = false;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // buttonSaveFile_PDS
            // 
            this.buttonSaveFile_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSaveFile_PDS.Enabled = false;
            this.buttonSaveFile_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_PDS.Image")));
            this.buttonSaveFile_PDS.Location = new System.Drawing.Point(195, 3);
            this.buttonSaveFile_PDS.Name = "buttonSaveFile_PDS";
            this.buttonSaveFile_PDS.Size = new System.Drawing.Size(90, 77);
            this.buttonSaveFile_PDS.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonSaveFile_PDS, "Сохранить файл");
            this.buttonSaveFile_PDS.UseVisualStyleBackColor = false;
            this.buttonSaveFile_PDS.Click += new System.EventHandler(this.buttonSaveFile_PDS_Click);
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_PDS.Enabled = false;
            this.buttonDone_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PDS.Image")));
            this.buttonDone_PDS.Location = new System.Drawing.Point(99, 3);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(90, 77);
            this.buttonDone_PDS.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonDone_PDS, "Выполнить скрипт");
            this.buttonDone_PDS.UseVisualStyleBackColor = false;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // buttonOpenFile_PDS
            // 
            this.buttonOpenFile_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile_PDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PDS.Image")));
            this.buttonOpenFile_PDS.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_PDS.Name = "buttonOpenFile_PDS";
            this.buttonOpenFile_PDS.Size = new System.Drawing.Size(90, 77);
            this.buttonOpenFile_PDS.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile_PDS, "Открыть файл");
            this.buttonOpenFile_PDS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PDS.Click += new System.EventHandler(this.buttonOpenFile_PDS_Click);
            // 
            // panelTask_PDS
            // 
            this.panelTask_PDS.Controls.Add(this.groupBoxTask_PDS);
            this.panelTask_PDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PDS.Location = new System.Drawing.Point(0, 83);
            this.panelTask_PDS.Name = "panelTask_PDS";
            this.panelTask_PDS.Size = new System.Drawing.Size(897, 88);
            this.panelTask_PDS.TabIndex = 0;
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.textBoxTask_PDS);
            this.groupBoxTask_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(897, 88);
            this.groupBoxTask_PDS.TabIndex = 0;
            this.groupBoxTask_PDS.TabStop = false;
            this.groupBoxTask_PDS.Text = "Условие:";
            // 
            // textBoxTask_PDS
            // 
            this.textBoxTask_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_PDS.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_PDS.Multiline = true;
            this.textBoxTask_PDS.Name = "textBoxTask_PDS";
            this.textBoxTask_PDS.ReadOnly = true;
            this.textBoxTask_PDS.Size = new System.Drawing.Size(891, 69);
            this.textBoxTask_PDS.TabIndex = 0;
            this.textBoxTask_PDS.Text = resources.GetString("textBoxTask_PDS.Text");
            // 
            // panelIO_PDS
            // 
            this.panelIO_PDS.Controls.Add(this.splitter1);
            this.panelIO_PDS.Controls.Add(this.groupBoxOutput_PDS);
            this.panelIO_PDS.Controls.Add(this.groupBoxInput_PDS);
            this.panelIO_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIO_PDS.Location = new System.Drawing.Point(0, 171);
            this.panelIO_PDS.Name = "panelIO_PDS";
            this.panelIO_PDS.Size = new System.Drawing.Size(897, 310);
            this.panelIO_PDS.TabIndex = 1;
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.dataGridViewOutput_PDS);
            this.groupBoxOutput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(473, 0);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(424, 310);
            this.groupBoxOutput_PDS.TabIndex = 0;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод:";
            // 
            // dataGridViewOutput_PDS
            // 
            this.dataGridViewOutput_PDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOutput_PDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_PDS.ColumnHeadersVisible = false;
            this.dataGridViewOutput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_PDS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_PDS.Name = "dataGridViewOutput_PDS";
            this.dataGridViewOutput_PDS.RowHeadersVisible = false;
            this.dataGridViewOutput_PDS.Size = new System.Drawing.Size(418, 291);
            this.dataGridViewOutput_PDS.TabIndex = 0;
            // 
            // groupBoxInput_PDS
            // 
            this.groupBoxInput_PDS.Controls.Add(this.dataGridViewInput_PDS);
            this.groupBoxInput_PDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput_PDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_PDS.Name = "groupBoxInput_PDS";
            this.groupBoxInput_PDS.Size = new System.Drawing.Size(473, 310);
            this.groupBoxInput_PDS.TabIndex = 0;
            this.groupBoxInput_PDS.TabStop = false;
            this.groupBoxInput_PDS.Text = "Ввод:";
            // 
            // dataGridViewInput_PDS
            // 
            this.dataGridViewInput_PDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInput_PDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_PDS.ColumnHeadersVisible = false;
            this.dataGridViewInput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_PDS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_PDS.Name = "dataGridViewInput_PDS";
            this.dataGridViewInput_PDS.RowHeadersVisible = false;
            this.dataGridViewInput_PDS.Size = new System.Drawing.Size(467, 291);
            this.dataGridViewInput_PDS.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask_PDS";
            // 
            // saveFileDialogTask
            // 
            this.saveFileDialogTask.FileName = "saveFileDialogTask_PDS";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(473, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 310);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 481);
            this.Controls.Add(this.panelIO_PDS);
            this.Controls.Add(this.panelTask_PDS);
            this.Controls.Add(this.panelActions_PDS);
            this.MinimumSize = new System.Drawing.Size(850, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 6 | Помаз Д.С";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelActions_PDS.ResumeLayout(false);
            this.panelTask_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.PerformLayout();
            this.panelIO_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PDS)).EndInit();
            this.groupBoxInput_PDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.Button buttonOpenFile_PDS;
        private System.Windows.Forms.Panel panelTask_PDS;
        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.TextBox textBoxTask_PDS;
        private System.Windows.Forms.Panel panelIO_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.GroupBox groupBoxInput_PDS;
        private System.Windows.Forms.DataGridView dataGridViewInput_PDS;
        private System.Windows.Forms.Button buttonSaveFile_PDS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataGridViewOutput_PDS;
        private System.Windows.Forms.Splitter splitter1;
    }
}

