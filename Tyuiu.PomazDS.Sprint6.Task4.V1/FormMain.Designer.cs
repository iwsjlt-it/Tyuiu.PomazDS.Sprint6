namespace Tyuiu.PomazDS.Sprint6.Task4.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_PDS = new System.Windows.Forms.Panel();
            this.groupBoxInput_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxInputStopValue_PDS = new System.Windows.Forms.TextBox();
            this.textBoxInputStartValue_PDS = new System.Windows.Forms.TextBox();
            this.labelStart_PDS = new System.Windows.Forms.Label();
            this.labelStop_PDS = new System.Windows.Forms.Label();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.buttonSave_PDS = new System.Windows.Forms.Button();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.groupBoxTask_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PDS = new System.Windows.Forms.TextBox();
            this.panelLeft_PDS = new System.Windows.Forms.Panel();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PDS = new System.Windows.Forms.TextBox();
            this.labelResult_PDS = new System.Windows.Forms.Label();
            this.panelFill_PDS = new System.Windows.Forms.Panel();
            this.chartFunction_PDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOutput_PDS = new System.Windows.Forms.Splitter();
            this.panelTop_PDS.SuspendLayout();
            this.groupBoxInput_PDS.SuspendLayout();
            this.groupBoxTask_PDS.SuspendLayout();
            this.panelLeft_PDS.SuspendLayout();
            this.groupBoxOutput_PDS.SuspendLayout();
            this.panelFill_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_PDS
            // 
            this.panelTop_PDS.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop_PDS.Controls.Add(this.groupBoxInput_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonHelp_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonSave_PDS);
            this.panelTop_PDS.Controls.Add(this.buttonDone_PDS);
            this.panelTop_PDS.Controls.Add(this.groupBoxTask_PDS);
            this.panelTop_PDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PDS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PDS.Name = "panelTop_PDS";
            this.panelTop_PDS.Size = new System.Drawing.Size(984, 86);
            this.panelTop_PDS.TabIndex = 0;
            // 
            // groupBoxInput_PDS
            // 
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInputStopValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInputStartValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.labelStart_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.labelStop_PDS);
            this.groupBoxInput_PDS.Location = new System.Drawing.Point(423, 5);
            this.groupBoxInput_PDS.Name = "groupBoxInput_PDS";
            this.groupBoxInput_PDS.Size = new System.Drawing.Size(280, 75);
            this.groupBoxInput_PDS.TabIndex = 2;
            this.groupBoxInput_PDS.TabStop = false;
            this.groupBoxInput_PDS.Text = "Ввод данных:";
            // 
            // textBoxInputStopValue_PDS
            // 
            this.textBoxInputStopValue_PDS.Location = new System.Drawing.Point(156, 35);
            this.textBoxInputStopValue_PDS.Multiline = true;
            this.textBoxInputStopValue_PDS.Name = "textBoxInputStopValue_PDS";
            this.textBoxInputStopValue_PDS.Size = new System.Drawing.Size(118, 20);
            this.textBoxInputStopValue_PDS.TabIndex = 1;
            // 
            // textBoxInputStartValue_PDS
            // 
            this.textBoxInputStartValue_PDS.Location = new System.Drawing.Point(9, 35);
            this.textBoxInputStartValue_PDS.Multiline = true;
            this.textBoxInputStartValue_PDS.Name = "textBoxInputStartValue_PDS";
            this.textBoxInputStartValue_PDS.Size = new System.Drawing.Size(118, 20);
            this.textBoxInputStartValue_PDS.TabIndex = 0;
            // 
            // labelStart_PDS
            // 
            this.labelStart_PDS.AutoSize = true;
            this.labelStart_PDS.Location = new System.Drawing.Point(6, 19);
            this.labelStart_PDS.Name = "labelStart_PDS";
            this.labelStart_PDS.Size = new System.Drawing.Size(75, 13);
            this.labelStart_PDS.TabIndex = 0;
            this.labelStart_PDS.Text = "Начало шага:";
            // 
            // labelStop_PDS
            // 
            this.labelStop_PDS.AutoSize = true;
            this.labelStop_PDS.Location = new System.Drawing.Point(153, 19);
            this.labelStop_PDS.Name = "labelStop_PDS";
            this.labelStop_PDS.Size = new System.Drawing.Size(69, 13);
            this.labelStop_PDS.TabIndex = 0;
            this.labelStop_PDS.Text = "Конец шага:";
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PDS.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_PDS.Location = new System.Drawing.Point(906, 20);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(75, 50);
            this.buttonHelp_PDS.TabIndex = 4;
            this.buttonHelp_PDS.Text = "Справка";
            this.buttonHelp_PDS.UseVisualStyleBackColor = false;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // buttonSave_PDS
            // 
            this.buttonSave_PDS.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave_PDS.Location = new System.Drawing.Point(790, 20);
            this.buttonSave_PDS.Name = "buttonSave_PDS";
            this.buttonSave_PDS.Size = new System.Drawing.Size(75, 50);
            this.buttonSave_PDS.TabIndex = 3;
            this.buttonSave_PDS.Text = "Сохранить";
            this.buttonSave_PDS.UseVisualStyleBackColor = false;
            this.buttonSave_PDS.Click += new System.EventHandler(this.buttonSave_PDS_Click);
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_PDS.Location = new System.Drawing.Point(709, 21);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(75, 49);
            this.buttonDone_PDS.TabIndex = 2;
            this.buttonDone_PDS.Text = "Выполнить";
            this.buttonDone_PDS.UseVisualStyleBackColor = false;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.textBoxTask_PDS);
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(12, 5);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(405, 75);
            this.groupBoxTask_PDS.TabIndex = 0;
            this.groupBoxTask_PDS.TabStop = false;
            this.groupBoxTask_PDS.Text = "Условие:";
            // 
            // textBoxTask_PDS
            // 
            this.textBoxTask_PDS.Location = new System.Drawing.Point(6, 16);
            this.textBoxTask_PDS.Multiline = true;
            this.textBoxTask_PDS.Name = "textBoxTask_PDS";
            this.textBoxTask_PDS.ReadOnly = true;
            this.textBoxTask_PDS.Size = new System.Drawing.Size(393, 48);
            this.textBoxTask_PDS.TabIndex = 0;
            this.textBoxTask_PDS.TabStop = false;
            this.textBoxTask_PDS.Text = "Протабулировать функцию f(x) на заданном диапазоне -5 до 5. Результат вывести в t" +
    "extBox, построить график фукнции и сохранить в файл OutPutFileTask.txt по нажати" +
    "ю кнопки";
            // 
            // panelLeft_PDS
            // 
            this.panelLeft_PDS.BackColor = System.Drawing.SystemColors.Window;
            this.panelLeft_PDS.Controls.Add(this.groupBoxOutput_PDS);
            this.panelLeft_PDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PDS.Location = new System.Drawing.Point(0, 86);
            this.panelLeft_PDS.Name = "panelLeft_PDS";
            this.panelLeft_PDS.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft_PDS.Size = new System.Drawing.Size(192, 375);
            this.panelLeft_PDS.TabIndex = 0;
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.textBoxResult_PDS);
            this.groupBoxOutput_PDS.Controls.Add(this.labelResult_PDS);
            this.groupBoxOutput_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(186, 369);
            this.groupBoxOutput_PDS.TabIndex = 6;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод данных:";
            // 
            // textBoxResult_PDS
            // 
            this.textBoxResult_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_PDS.Location = new System.Drawing.Point(3, 33);
            this.textBoxResult_PDS.Multiline = true;
            this.textBoxResult_PDS.Name = "textBoxResult_PDS";
            this.textBoxResult_PDS.ReadOnly = true;
            this.textBoxResult_PDS.Size = new System.Drawing.Size(180, 333);
            this.textBoxResult_PDS.TabIndex = 6;
            this.textBoxResult_PDS.TabStop = false;
            // 
            // labelResult_PDS
            // 
            this.labelResult_PDS.AutoSize = true;
            this.labelResult_PDS.Location = new System.Drawing.Point(6, 17);
            this.labelResult_PDS.Name = "labelResult_PDS";
            this.labelResult_PDS.Size = new System.Drawing.Size(62, 13);
            this.labelResult_PDS.TabIndex = 0;
            this.labelResult_PDS.Text = "Результат:";
            // 
            // panelFill_PDS
            // 
            this.panelFill_PDS.BackColor = System.Drawing.SystemColors.Window;
            this.panelFill_PDS.Controls.Add(this.chartFunction_PDS);
            this.panelFill_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PDS.Location = new System.Drawing.Point(192, 86);
            this.panelFill_PDS.Name = "panelFill_PDS";
            this.panelFill_PDS.Padding = new System.Windows.Forms.Padding(3);
            this.panelFill_PDS.Size = new System.Drawing.Size(792, 375);
            this.panelFill_PDS.TabIndex = 0;
            // 
            // chartFunction_PDS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PDS.ChartAreas.Add(chartArea1);
            this.chartFunction_PDS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_PDS.Legends.Add(legend1);
            this.chartFunction_PDS.Location = new System.Drawing.Point(3, 3);
            this.chartFunction_PDS.Name = "chartFunction_PDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PDS.Series.Add(series1);
            this.chartFunction_PDS.Size = new System.Drawing.Size(786, 369);
            this.chartFunction_PDS.TabIndex = 1;
            this.chartFunction_PDS.TabStop = false;
            this.chartFunction_PDS.Text = "chart1";
            // 
            // splitterOutput_PDS
            // 
            this.splitterOutput_PDS.Location = new System.Drawing.Point(192, 86);
            this.splitterOutput_PDS.Name = "splitterOutput_PDS";
            this.splitterOutput_PDS.Size = new System.Drawing.Size(3, 375);
            this.splitterOutput_PDS.TabIndex = 1;
            this.splitterOutput_PDS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.splitterOutput_PDS);
            this.Controls.Add(this.panelFill_PDS);
            this.Controls.Add(this.panelLeft_PDS);
            this.Controls.Add(this.panelTop_PDS);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 1 | Помаз Д.С";
            this.panelTop_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.PerformLayout();
            this.groupBoxTask_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.PerformLayout();
            this.panelLeft_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.PerformLayout();
            this.panelFill_PDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PDS;
        private System.Windows.Forms.Panel panelLeft_PDS;
        private System.Windows.Forms.Panel panelFill_PDS;
        private System.Windows.Forms.Splitter splitterOutput_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.TextBox textBoxResult_PDS;
        private System.Windows.Forms.Label labelResult_PDS;
        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.Button buttonSave_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.GroupBox groupBoxInput_PDS;
        private System.Windows.Forms.Label labelStop_PDS;
        private System.Windows.Forms.TextBox textBoxInputStartValue_PDS;
        private System.Windows.Forms.Label labelStart_PDS;
        private System.Windows.Forms.TextBox textBoxInputStopValue_PDS;
        private System.Windows.Forms.TextBox textBoxTask_PDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PDS;
    }
}

