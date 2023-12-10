namespace Tyuiu.PomazDS.Sprint6.Task5.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_PDS = new System.Windows.Forms.Panel();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.buttonOpenFile_PDS = new System.Windows.Forms.Button();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.groupBoxTask_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PDS = new System.Windows.Forms.TextBox();
            this.panelLeft_PDS = new System.Windows.Forms.Panel();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_PDS = new System.Windows.Forms.DataGridView();
            this.ColumnNumber_PDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNums_PDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelFill_PDS = new System.Windows.Forms.Panel();
            this.chartResult_PDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelTop_PDS.SuspendLayout();
            this.groupBoxTask_PDS.SuspendLayout();
            this.panelLeft_PDS.SuspendLayout();
            this.groupBoxOutput_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PDS)).BeginInit();
            this.panelFill_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_PDS
            // 
            this.panelTop_PDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTop_PDS.Controls.Add(this.buttonHelp_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonOpenFile_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonDone_PDS);
            this.panelTop_PDS.Controls.Add(this.groupBoxTask_PDS);
            this.panelTop_PDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PDS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PDS.Name = "panelTop_PDS";
            this.panelTop_PDS.Size = new System.Drawing.Size(800, 100);
            this.panelTop_PDS.TabIndex = 0;
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PDS.Location = new System.Drawing.Point(716, 23);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(81, 62);
            this.buttonHelp_PDS.TabIndex = 0;
            this.buttonHelp_PDS.Text = "Справка";
            this.buttonHelp_PDS.UseVisualStyleBackColor = true;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // buttonOpenFile_PDS
            // 
            this.buttonOpenFile_PDS.Location = new System.Drawing.Point(514, 23);
            this.buttonOpenFile_PDS.Name = "buttonOpenFile_PDS";
            this.buttonOpenFile_PDS.Size = new System.Drawing.Size(81, 62);
            this.buttonOpenFile_PDS.TabIndex = 0;
            this.buttonOpenFile_PDS.Text = "Открыть файл";
            this.buttonOpenFile_PDS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PDS.Click += new System.EventHandler(this.buttonOpenFile_PDS_Click);
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.Location = new System.Drawing.Point(427, 23);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(81, 62);
            this.buttonDone_PDS.TabIndex = 0;
            this.buttonDone_PDS.Text = "Выполнить";
            this.buttonDone_PDS.UseVisualStyleBackColor = true;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.textBoxTask_PDS);
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(9, 3);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(412, 94);
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
            this.textBoxTask_PDS.Size = new System.Drawing.Size(406, 75);
            this.textBoxTask_PDS.TabIndex = 0;
            this.textBoxTask_PDS.Text = resources.GetString("textBoxTask_PDS.Text");
            // 
            // panelLeft_PDS
            // 
            this.panelLeft_PDS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLeft_PDS.Controls.Add(this.groupBoxOutput_PDS);
            this.panelLeft_PDS.Controls.Add(this.splitter1);
            this.panelLeft_PDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PDS.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_PDS.Name = "panelLeft_PDS";
            this.panelLeft_PDS.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft_PDS.Size = new System.Drawing.Size(210, 350);
            this.panelLeft_PDS.TabIndex = 0;
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.dataGridViewResult_PDS);
            this.groupBoxOutput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(6, 3);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(201, 344);
            this.groupBoxOutput_PDS.TabIndex = 1;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод данных:";
            // 
            // dataGridViewResult_PDS
            // 
            this.dataGridViewResult_PDS.AllowUserToAddRows = false;
            this.dataGridViewResult_PDS.AllowUserToDeleteRows = false;
            this.dataGridViewResult_PDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber_PDS,
            this.ColumnNums_PDS});
            this.dataGridViewResult_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_PDS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_PDS.Name = "dataGridViewResult_PDS";
            this.dataGridViewResult_PDS.ReadOnly = true;
            this.dataGridViewResult_PDS.RowHeadersVisible = false;
            this.dataGridViewResult_PDS.Size = new System.Drawing.Size(195, 325);
            this.dataGridViewResult_PDS.TabIndex = 0;
            // 
            // ColumnNumber_PDS
            // 
            this.ColumnNumber_PDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumber_PDS.HeaderText = "Number";
            this.ColumnNumber_PDS.Name = "ColumnNumber_PDS";
            this.ColumnNumber_PDS.ReadOnly = true;
            // 
            // ColumnNums_PDS
            // 
            this.ColumnNums_PDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNums_PDS.HeaderText = "Nums";
            this.ColumnNums_PDS.Name = "ColumnNums_PDS";
            this.ColumnNums_PDS.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 344);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panelFill_PDS
            // 
            this.panelFill_PDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFill_PDS.Controls.Add(this.chartResult_PDS);
            this.panelFill_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PDS.Location = new System.Drawing.Point(210, 100);
            this.panelFill_PDS.Name = "panelFill_PDS";
            this.panelFill_PDS.Size = new System.Drawing.Size(590, 350);
            this.panelFill_PDS.TabIndex = 0;
            // 
            // chartResult_PDS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_PDS.ChartAreas.Add(chartArea2);
            this.chartResult_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartResult_PDS.Legends.Add(legend2);
            this.chartResult_PDS.Location = new System.Drawing.Point(0, 0);
            this.chartResult_PDS.Name = "chartResult_PDS";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_PDS.Series.Add(series2);
            this.chartResult_PDS.Size = new System.Drawing.Size(590, 350);
            this.chartResult_PDS.TabIndex = 0;
            this.chartResult_PDS.Text = "chart1";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(210, 100);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 350);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panelFill_PDS);
            this.Controls.Add(this.panelLeft_PDS);
            this.Controls.Add(this.panelTop_PDS);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 17 | Помаз Д.С";
            this.panelTop_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.PerformLayout();
            this.panelLeft_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PDS)).EndInit();
            this.panelFill_PDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PDS;
        private System.Windows.Forms.Panel panelLeft_PDS;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelFill_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.DataGridView dataGridViewResult_PDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.Button buttonOpenFile_PDS;
        private System.Windows.Forms.TextBox textBoxTask_PDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber_PDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNums_PDS;
        private System.Windows.Forms.Splitter splitter2;
    }
}

