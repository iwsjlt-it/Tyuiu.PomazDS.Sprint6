namespace Tyuiu.PomazDS.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_PDS = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_PDS = new System.Windows.Forms.GroupBox();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.textBoxInputStopValue_PDS = new System.Windows.Forms.TextBox();
            this.textBoxInputStartValue_PDS = new System.Windows.Forms.TextBox();
            this.labelInputStopValue_PDS = new System.Windows.Forms.Label();
            this.labelInputStartValue_PDS = new System.Windows.Forms.Label();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.chartFunction_PDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_PDS = new System.Windows.Forms.DataGridView();
            this.labelOutput_PDS = new System.Windows.Forms.Label();
            this.dataServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColumnX_PDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction_PDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxTask_PDS = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_PDS.SuspendLayout();
            this.groupBoxInput_PDS.SuspendLayout();
            this.groupBoxOutput_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.pictureBoxTask_PDS);
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(12, 0);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(490, 355);
            this.groupBoxTask_PDS.TabIndex = 0;
            this.groupBoxTask_PDS.TabStop = false;
            this.groupBoxTask_PDS.Text = "Условие:";
            // 
            // groupBoxInput_PDS
            // 
            this.groupBoxInput_PDS.Controls.Add(this.buttonDone_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.buttonHelp_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInputStopValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInputStartValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.labelInputStopValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.labelInputStartValue_PDS);
            this.groupBoxInput_PDS.Location = new System.Drawing.Point(12, 361);
            this.groupBoxInput_PDS.Name = "groupBoxInput_PDS";
            this.groupBoxInput_PDS.Size = new System.Drawing.Size(490, 84);
            this.groupBoxInput_PDS.TabIndex = 0;
            this.groupBoxInput_PDS.TabStop = false;
            this.groupBoxInput_PDS.Text = "Ввод данных:";
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PDS.Location = new System.Drawing.Point(347, 19);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(137, 59);
            this.buttonDone_PDS.TabIndex = 3;
            this.buttonDone_PDS.Text = "Выполнить";
            this.buttonDone_PDS.UseVisualStyleBackColor = false;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            this.buttonDone_PDS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PDS_MouseDown);
            this.buttonDone_PDS.MouseEnter += new System.EventHandler(this.buttonDone_PDS_MouseEnter);
            this.buttonDone_PDS.MouseLeave += new System.EventHandler(this.buttonDone_PDS_MouseLeave);
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.BackColor = System.Drawing.Color.Yellow;
            this.buttonHelp_PDS.Location = new System.Drawing.Point(249, 18);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(92, 59);
            this.buttonHelp_PDS.TabIndex = 4;
            this.buttonHelp_PDS.Text = "Справка";
            this.buttonHelp_PDS.UseVisualStyleBackColor = false;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // textBoxInputStopValue_PDS
            // 
            this.textBoxInputStopValue_PDS.Location = new System.Drawing.Point(132, 43);
            this.textBoxInputStopValue_PDS.Name = "textBoxInputStopValue_PDS";
            this.textBoxInputStopValue_PDS.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputStopValue_PDS.TabIndex = 2;
            // 
            // textBoxInputStartValue_PDS
            // 
            this.textBoxInputStartValue_PDS.Location = new System.Drawing.Point(6, 43);
            this.textBoxInputStartValue_PDS.Name = "textBoxInputStartValue_PDS";
            this.textBoxInputStartValue_PDS.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputStartValue_PDS.TabIndex = 1;
            // 
            // labelInputStopValue_PDS
            // 
            this.labelInputStopValue_PDS.AutoSize = true;
            this.labelInputStopValue_PDS.Location = new System.Drawing.Point(129, 16);
            this.labelInputStopValue_PDS.Name = "labelInputStopValue_PDS";
            this.labelInputStopValue_PDS.Size = new System.Drawing.Size(69, 13);
            this.labelInputStopValue_PDS.TabIndex = 0;
            this.labelInputStopValue_PDS.Text = "Конец шага:";
            // 
            // labelInputStartValue_PDS
            // 
            this.labelInputStartValue_PDS.AutoSize = true;
            this.labelInputStartValue_PDS.Location = new System.Drawing.Point(3, 16);
            this.labelInputStartValue_PDS.Name = "labelInputStartValue_PDS";
            this.labelInputStartValue_PDS.Size = new System.Drawing.Size(75, 13);
            this.labelInputStartValue_PDS.TabIndex = 0;
            this.labelInputStartValue_PDS.Text = "Начало шага:";
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.chartFunction_PDS);
            this.groupBoxOutput_PDS.Controls.Add(this.dataGridViewFunction_PDS);
            this.groupBoxOutput_PDS.Controls.Add(this.labelOutput_PDS);
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(508, 0);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(730, 445);
            this.groupBoxOutput_PDS.TabIndex = 1;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод данных:";
            // 
            // chartFunction_PDS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PDS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PDS.Legends.Add(legend1);
            this.chartFunction_PDS.Location = new System.Drawing.Point(212, 32);
            this.chartFunction_PDS.Name = "chartFunction_PDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PDS.Series.Add(series1);
            this.chartFunction_PDS.Size = new System.Drawing.Size(512, 406);
            this.chartFunction_PDS.TabIndex = 2;
            this.chartFunction_PDS.Text = "График";
            // 
            // dataGridViewFunction_PDS
            // 
            this.dataGridViewFunction_PDS.AllowUserToAddRows = false;
            this.dataGridViewFunction_PDS.AllowUserToDeleteRows = false;
            this.dataGridViewFunction_PDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_PDS,
            this.ColumnFunction_PDS});
            this.dataGridViewFunction_PDS.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewFunction_PDS.Name = "dataGridViewFunction_PDS";
            this.dataGridViewFunction_PDS.ReadOnly = true;
            this.dataGridViewFunction_PDS.RowHeadersVisible = false;
            this.dataGridViewFunction_PDS.Size = new System.Drawing.Size(203, 406);
            this.dataGridViewFunction_PDS.TabIndex = 1;
            // 
            // labelOutput_PDS
            // 
            this.labelOutput_PDS.AutoSize = true;
            this.labelOutput_PDS.Location = new System.Drawing.Point(6, 16);
            this.labelOutput_PDS.Name = "labelOutput_PDS";
            this.labelOutput_PDS.Size = new System.Drawing.Size(62, 13);
            this.labelOutput_PDS.TabIndex = 0;
            this.labelOutput_PDS.Text = "Результат:";
            // 
            // dataServiceBindingSource
            // 
            this.dataServiceBindingSource.DataSource = typeof(Tyuiu.PomazDS.Sprint6.Task2.V3.Lib.DataService);
            // 
            // ColumnX_PDS
            // 
            this.ColumnX_PDS.HeaderText = "X";
            this.ColumnX_PDS.Name = "ColumnX_PDS";
            this.ColumnX_PDS.ReadOnly = true;
            // 
            // ColumnFunction_PDS
            // 
            this.ColumnFunction_PDS.HeaderText = "F(X)";
            this.ColumnFunction_PDS.Name = "ColumnFunction_PDS";
            this.ColumnFunction_PDS.ReadOnly = true;
            // 
            // pictureBoxTask_PDS
            // 
            this.pictureBoxTask_PDS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_PDS.Image")));
            this.pictureBoxTask_PDS.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxTask_PDS.Name = "pictureBoxTask_PDS";
            this.pictureBoxTask_PDS.Size = new System.Drawing.Size(478, 201);
            this.pictureBoxTask_PDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTask_PDS.TabIndex = 3;
            this.pictureBoxTask_PDS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.groupBoxOutput_PDS);
            this.Controls.Add(this.groupBoxInput_PDS);
            this.Controls.Add(this.groupBoxTask_PDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Помаз Д.С";
            this.groupBoxTask_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.PerformLayout();
            this.groupBoxOutput_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.GroupBox groupBoxInput_PDS;
        private System.Windows.Forms.Label labelInputStopValue_PDS;
        private System.Windows.Forms.Label labelInputStartValue_PDS;
        private System.Windows.Forms.TextBox textBoxInputStopValue_PDS;
        private System.Windows.Forms.TextBox textBoxInputStartValue_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.Label labelOutput_PDS;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PDS;
        private System.Windows.Forms.BindingSource dataServiceBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_PDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction_PDS;
        private System.Windows.Forms.PictureBox pictureBoxTask_PDS;
    }
}

