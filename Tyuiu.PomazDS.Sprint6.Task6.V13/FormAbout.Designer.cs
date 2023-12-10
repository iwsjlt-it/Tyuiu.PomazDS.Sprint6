namespace Tyuiu.PomazDS.Sprint6.Task6.V13
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
            this.pictureBoxAvatar_PDS = new System.Windows.Forms.PictureBox();
            this.labelInfo_PDS = new System.Windows.Forms.Label();
            this.buttonOk_PDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PDS
            // 
            this.pictureBoxAvatar_PDS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PDS.Image")));
            this.pictureBoxAvatar_PDS.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar_PDS.Name = "pictureBoxAvatar_PDS";
            this.pictureBoxAvatar_PDS.Size = new System.Drawing.Size(166, 231);
            this.pictureBoxAvatar_PDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PDS.TabIndex = 0;
            this.pictureBoxAvatar_PDS.TabStop = false;
            // 
            // labelInfo_PDS
            // 
            this.labelInfo_PDS.AutoSize = true;
            this.labelInfo_PDS.Location = new System.Drawing.Point(172, 9);
            this.labelInfo_PDS.Name = "labelInfo_PDS";
            this.labelInfo_PDS.Size = new System.Drawing.Size(249, 130);
            this.labelInfo_PDS.TabIndex = 1;
            this.labelInfo_PDS.Text = "Разработчик: Помаз Д.С\r\nгруппа ИИПб-23-2\r\n\r\nПрограмма разработана в рамках изучен" +
    "ия C#\r\n\r\nТИУ 2023\r\nВШЦТ 2023\r\n\r\n\r\n\r\n";
            // 
            // buttonOk_PDS
            // 
            this.buttonOk_PDS.Location = new System.Drawing.Point(272, 160);
            this.buttonOk_PDS.Name = "buttonOk_PDS";
            this.buttonOk_PDS.Size = new System.Drawing.Size(137, 61);
            this.buttonOk_PDS.TabIndex = 2;
            this.buttonOk_PDS.Text = "Понял";
            this.buttonOk_PDS.UseVisualStyleBackColor = true;
            this.buttonOk_PDS.Click += new System.EventHandler(this.buttonOk_PDS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 233);
            this.Controls.Add(this.buttonOk_PDS);
            this.Controls.Add(this.labelInfo_PDS);
            this.Controls.Add(this.pictureBoxAvatar_PDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PDS;
        private System.Windows.Forms.Label labelInfo_PDS;
        private System.Windows.Forms.Button buttonOk_PDS;
    }
}