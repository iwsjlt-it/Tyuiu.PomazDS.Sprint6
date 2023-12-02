namespace Tyuiu.PomazDS.Sprint6.Task1.V2
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
            this.groupBoxTask_PDS = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_PDS = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxInputStopValue_PDS = new System.Windows.Forms.TextBox();
            this.textBoxInputStartValue_PDS = new System.Windows.Forms.TextBox();
            this.labelInputStopValue_PDS = new System.Windows.Forms.Label();
            this.labelInputStartValue_PDS = new System.Windows.Forms.Label();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_PDS = new System.Windows.Forms.TextBox();
            this.labelOutput_PDS = new System.Windows.Forms.Label();
            this.groupBoxTask_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDS)).BeginInit();
            this.groupBoxInput_PDS.SuspendLayout();
            this.groupBoxOutput_PDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.pictureBoxTask_PDS);
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(510, 344);
            this.groupBoxTask_PDS.TabIndex = 0;
            this.groupBoxTask_PDS.TabStop = false;
            this.groupBoxTask_PDS.Text = "Условие:";
            // 
            // pictureBoxTask_PDS
            // 
            this.pictureBoxTask_PDS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_PDS.Image")));
            this.pictureBoxTask_PDS.Location = new System.Drawing.Point(32, 32);
            this.pictureBoxTask_PDS.Name = "pictureBoxTask_PDS";
            this.pictureBoxTask_PDS.Size = new System.Drawing.Size(452, 183);
            this.pictureBoxTask_PDS.TabIndex = 0;
            this.pictureBoxTask_PDS.TabStop = false;
            // 
            // groupBoxInput_PDS
            // 
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInputStopValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInputStartValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.labelInputStopValue_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.labelInputStartValue_PDS);
            this.groupBoxInput_PDS.Location = new System.Drawing.Point(12, 362);
            this.groupBoxInput_PDS.Name = "groupBoxInput_PDS";
            this.groupBoxInput_PDS.Size = new System.Drawing.Size(304, 76);
            this.groupBoxInput_PDS.TabIndex = 1;
            this.groupBoxInput_PDS.TabStop = false;
            this.groupBoxInput_PDS.Text = "Ввод данных:";
            // 
            // textBoxInputStopValue_PDS
            // 
            this.textBoxInputStopValue_PDS.Location = new System.Drawing.Point(168, 41);
            this.textBoxInputStopValue_PDS.Multiline = true;
            this.textBoxInputStopValue_PDS.Name = "textBoxInputStopValue_PDS";
            this.textBoxInputStopValue_PDS.Size = new System.Drawing.Size(108, 20);
            this.textBoxInputStopValue_PDS.TabIndex = 2;
            // 
            // textBoxInputStartValue_PDS
            // 
            this.textBoxInputStartValue_PDS.Location = new System.Drawing.Point(9, 41);
            this.textBoxInputStartValue_PDS.Multiline = true;
            this.textBoxInputStartValue_PDS.Name = "textBoxInputStartValue_PDS";
            this.textBoxInputStartValue_PDS.Size = new System.Drawing.Size(108, 20);
            this.textBoxInputStartValue_PDS.TabIndex = 1;
            // 
            // labelInputStopValue_PDS
            // 
            this.labelInputStopValue_PDS.AutoSize = true;
            this.labelInputStopValue_PDS.Location = new System.Drawing.Point(165, 16);
            this.labelInputStopValue_PDS.Name = "labelInputStopValue_PDS";
            this.labelInputStopValue_PDS.Size = new System.Drawing.Size(69, 13);
            this.labelInputStopValue_PDS.TabIndex = 0;
            this.labelInputStopValue_PDS.Text = "Конец шага:";
            // 
            // labelInputStartValue_PDS
            // 
            this.labelInputStartValue_PDS.AutoSize = true;
            this.labelInputStartValue_PDS.Location = new System.Drawing.Point(6, 16);
            this.labelInputStartValue_PDS.Name = "labelInputStartValue_PDS";
            this.labelInputStartValue_PDS.Size = new System.Drawing.Size(67, 13);
            this.labelInputStartValue_PDS.TabIndex = 0;
            this.labelInputStartValue_PDS.Text = "Старт шага:";
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Location = new System.Drawing.Point(322, 378);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(70, 60);
            this.buttonHelp_PDS.TabIndex = 4;
            this.buttonHelp_PDS.Text = "Справка";
            this.buttonHelp_PDS.UseVisualStyleBackColor = true;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.Location = new System.Drawing.Point(398, 378);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(124, 60);
            this.buttonDone_PDS.TabIndex = 3;
            this.buttonDone_PDS.Text = "Выполнить";
            this.buttonDone_PDS.UseVisualStyleBackColor = true;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.textBoxOutput_PDS);
            this.groupBoxOutput_PDS.Controls.Add(this.labelOutput_PDS);
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(528, 12);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(269, 426);
            this.groupBoxOutput_PDS.TabIndex = 3;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод данных:";
            // 
            // textBoxOutput_PDS
            // 
            this.textBoxOutput_PDS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput_PDS.Location = new System.Drawing.Point(9, 32);
            this.textBoxOutput_PDS.Multiline = true;
            this.textBoxOutput_PDS.Name = "textBoxOutput_PDS";
            this.textBoxOutput_PDS.Size = new System.Drawing.Size(254, 388);
            this.textBoxOutput_PDS.TabIndex = 0;
            this.textBoxOutput_PDS.TabStop = false;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_PDS);
            this.Controls.Add(this.buttonDone_PDS);
            this.Controls.Add(this.buttonHelp_PDS);
            this.Controls.Add(this.groupBoxInput_PDS);
            this.Controls.Add(this.groupBoxTask_PDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 2 | Помаз Д.С";
            this.groupBoxTask_PDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDS)).EndInit();
            this.groupBoxInput_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.PerformLayout();
            this.groupBoxOutput_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.GroupBox groupBoxInput_PDS;
        private System.Windows.Forms.Label labelInputStopValue_PDS;
        private System.Windows.Forms.Label labelInputStartValue_PDS;
        private System.Windows.Forms.TextBox textBoxInputStartValue_PDS;
        private System.Windows.Forms.TextBox textBoxInputStopValue_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.TextBox textBoxOutput_PDS;
        private System.Windows.Forms.Label labelOutput_PDS;
        private System.Windows.Forms.PictureBox pictureBoxTask_PDS;
    }
}

