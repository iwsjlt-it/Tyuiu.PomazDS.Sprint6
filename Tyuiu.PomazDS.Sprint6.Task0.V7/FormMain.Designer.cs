using System.Drawing;

namespace Tyuiu.PomazDS.Sprint6.Task0.V7
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
            this.groupBoxTask_PDS = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_PDS = new System.Windows.Forms.PictureBox();
            this.textBoxTask_PDS = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.labelOutput_PDS = new System.Windows.Forms.Label();
            this.textBoxOutput_PDS = new System.Windows.Forms.TextBox();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.textBoxInput_PDS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PDS = new System.Windows.Forms.GroupBox();
            this.labelInput_PDS = new System.Windows.Forms.Label();
            this.groupBoxTask_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDS)).BeginInit();
            this.groupBoxOutput_PDS.SuspendLayout();
            this.groupBoxInput_PDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.pictureBoxTask_PDS);
            this.groupBoxTask_PDS.Controls.Add(this.textBoxTask_PDS);
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(776, 343);
            this.groupBoxTask_PDS.TabIndex = 0;
            this.groupBoxTask_PDS.TabStop = false;
            this.groupBoxTask_PDS.Text = "Условие:";
            // 
            // pictureBoxTask_PDS
            // 
            this.pictureBoxTask_PDS.Image = global::Tyuiu.PomazDS.Sprint6.Task0.V7.Properties.Resources.pictureTask0;
            this.pictureBoxTask_PDS.InitialImage = null;
            this.pictureBoxTask_PDS.Location = new System.Drawing.Point(306, 86);
            this.pictureBoxTask_PDS.Name = "pictureBoxTask_PDS";
            this.pictureBoxTask_PDS.Size = new System.Drawing.Size(132, 72);
            this.pictureBoxTask_PDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTask_PDS.TabIndex = 1;
            this.pictureBoxTask_PDS.TabStop = false;
            // 
            // textBoxTask_PDS
            // 
            this.textBoxTask_PDS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PDS.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTask_PDS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_PDS.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PDS.Multiline = true;
            this.textBoxTask_PDS.Name = "textBoxTask_PDS";
            this.textBoxTask_PDS.ReadOnly = true;
            this.textBoxTask_PDS.Size = new System.Drawing.Size(764, 297);
            this.textBoxTask_PDS.TabIndex = 2;
            this.textBoxTask_PDS.TabStop = false;
            this.textBoxTask_PDS.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой.";
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.labelOutput_PDS);
            this.groupBoxOutput_PDS.Controls.Add(this.textBoxOutput_PDS);
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(318, 361);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(255, 77);
            this.groupBoxOutput_PDS.TabIndex = 0;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод данных:";
            // 
            // labelOutput_PDS
            // 
            this.labelOutput_PDS.AutoSize = true;
            this.labelOutput_PDS.Location = new System.Drawing.Point(6, 16);
            this.labelOutput_PDS.Name = "labelOutput_PDS";
            this.labelOutput_PDS.Size = new System.Drawing.Size(62, 13);
            this.labelOutput_PDS.TabIndex = 1;
            this.labelOutput_PDS.Text = "Результат:";
            // 
            // textBoxOutput_PDS
            // 
            this.textBoxOutput_PDS.Location = new System.Drawing.Point(19, 43);
            this.textBoxOutput_PDS.Multiline = true;
            this.textBoxOutput_PDS.Name = "textBoxOutput_PDS";
            this.textBoxOutput_PDS.ReadOnly = true;
            this.textBoxOutput_PDS.Size = new System.Drawing.Size(218, 20);
            this.textBoxOutput_PDS.TabIndex = 0;
            this.textBoxOutput_PDS.TabStop = false;
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.Location = new System.Drawing.Point(623, 388);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(165, 50);
            this.buttonDone_PDS.TabIndex = 2;
            this.buttonDone_PDS.Text = "Выполнить";
            this.buttonDone_PDS.UseVisualStyleBackColor = true;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonHelp_PDS.Location = new System.Drawing.Point(579, 396);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(38, 42);
            this.buttonHelp_PDS.TabIndex = 3;
            this.buttonHelp_PDS.Text = "?";
            this.buttonHelp_PDS.UseVisualStyleBackColor = true;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // textBoxInput_PDS
            // 
            this.textBoxInput_PDS.Location = new System.Drawing.Point(9, 43);
            this.textBoxInput_PDS.Multiline = true;
            this.textBoxInput_PDS.Name = "textBoxInput_PDS";
            this.textBoxInput_PDS.Size = new System.Drawing.Size(254, 20);
            this.textBoxInput_PDS.TabIndex = 1;
            this.textBoxInput_PDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_PDS_KeyPress);
            // 
            // groupBoxInput_PDS
            // 
            this.groupBoxInput_PDS.Controls.Add(this.labelInput_PDS);
            this.groupBoxInput_PDS.Controls.Add(this.textBoxInput_PDS);
            this.groupBoxInput_PDS.Location = new System.Drawing.Point(12, 361);
            this.groupBoxInput_PDS.Name = "groupBoxInput_PDS";
            this.groupBoxInput_PDS.Size = new System.Drawing.Size(287, 77);
            this.groupBoxInput_PDS.TabIndex = 4;
            this.groupBoxInput_PDS.TabStop = false;
            this.groupBoxInput_PDS.Text = "Ввод данных:";
            // 
            // labelInput_PDS
            // 
            this.labelInput_PDS.AutoSize = true;
            this.labelInput_PDS.Location = new System.Drawing.Point(6, 16);
            this.labelInput_PDS.Name = "labelInput_PDS";
            this.labelInput_PDS.Size = new System.Drawing.Size(84, 13);
            this.labelInput_PDS.TabIndex = 4;
            this.labelInput_PDS.Text = "Введите число:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInput_PDS);
            this.Controls.Add(this.buttonHelp_PDS);
            this.Controls.Add(this.buttonDone_PDS);
            this.Controls.Add(this.groupBoxOutput_PDS);
            this.Controls.Add(this.groupBoxTask_PDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 7 | Помаз Д.С";
            this.groupBoxTask_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDS)).EndInit();
            this.groupBoxOutput_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.PerformLayout();
            this.groupBoxInput_PDS.ResumeLayout(false);
            this.groupBoxInput_PDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.PictureBox pictureBoxTask_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.TextBox textBoxOutput_PDS;
        private System.Windows.Forms.Label labelOutput_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.TextBox textBoxTask_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.TextBox textBoxInput_PDS;
        private System.Windows.Forms.GroupBox groupBoxInput_PDS;
        private System.Windows.Forms.Label labelInput_PDS;
    }
}

