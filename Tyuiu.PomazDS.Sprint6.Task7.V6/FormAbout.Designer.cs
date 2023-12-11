namespace Tyuiu.PomazDS.Sprint6.Task7.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_PDS = new System.Windows.Forms.Label();
            this.buttonOk_PDS = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_PDS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_PDS
            // 
            this.labelInfo_PDS.AutoSize = true;
            this.labelInfo_PDS.Location = new System.Drawing.Point(186, 30);
            this.labelInfo_PDS.Name = "labelInfo_PDS";
            this.labelInfo_PDS.Size = new System.Drawing.Size(249, 104);
            this.labelInfo_PDS.TabIndex = 0;
            this.labelInfo_PDS.Text = "Разработчик: Помаз Д.С\r\nгруппа ИИПб-23-2\r\n\r\nПрограмма разработана в рамках изучен" +
    "ия C#\r\n\r\nТИУ 2023\r\nВШЦТ 2023\r\n\r\n";
            // 
            // buttonOk_PDS
            // 
            this.buttonOk_PDS.Location = new System.Drawing.Point(282, 168);
            this.buttonOk_PDS.Name = "buttonOk_PDS";
            this.buttonOk_PDS.Size = new System.Drawing.Size(138, 48);
            this.buttonOk_PDS.TabIndex = 1;
            this.buttonOk_PDS.Text = "Принять";
            this.buttonOk_PDS.UseVisualStyleBackColor = true;
            this.buttonOk_PDS.Click += new System.EventHandler(this.buttonOk_PDS_Click);
            // 
            // pictureBoxAvatar_PDS
            // 
            this.pictureBoxAvatar_PDS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PDS.Image")));
            this.pictureBoxAvatar_PDS.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar_PDS.Name = "pictureBoxAvatar_PDS";
            this.pictureBoxAvatar_PDS.Size = new System.Drawing.Size(180, 231);
            this.pictureBoxAvatar_PDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PDS.TabIndex = 2;
            this.pictureBoxAvatar_PDS.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 228);
            this.Controls.Add(this.pictureBoxAvatar_PDS);
            this.Controls.Add(this.buttonOk_PDS);
            this.Controls.Add(this.labelInfo_PDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_PDS;
        private System.Windows.Forms.Button buttonOk_PDS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_PDS;
    }
}