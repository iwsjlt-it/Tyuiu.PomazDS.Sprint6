namespace Tyuiu.PomazDS.Sprint6.Task3.V9
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
            this.labelTaskMatrix_PDS = new System.Windows.Forms.Label();
            this.dataGridViewTaskMatrix_PDS = new System.Windows.Forms.DataGridView();
            this.textBoxTask_PDS = new System.Windows.Forms.TextBox();
            this.buttonDone_PDS = new System.Windows.Forms.Button();
            this.buttonHelp_PDS = new System.Windows.Forms.Button();
            this.groupBoxOutput_PDS = new System.Windows.Forms.GroupBox();
            this.labelResultMatrix_PDS = new System.Windows.Forms.Label();
            this.dataGridViewResultMatrix_PDS = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_PDS)).BeginInit();
            this.groupBoxOutput_PDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_PDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PDS
            // 
            this.groupBoxTask_PDS.Controls.Add(this.labelTaskMatrix_PDS);
            this.groupBoxTask_PDS.Controls.Add(this.dataGridViewTaskMatrix_PDS);
            this.groupBoxTask_PDS.Controls.Add(this.textBoxTask_PDS);
            this.groupBoxTask_PDS.Location = new System.Drawing.Point(12, 8);
            this.groupBoxTask_PDS.Name = "groupBoxTask_PDS";
            this.groupBoxTask_PDS.Size = new System.Drawing.Size(397, 445);
            this.groupBoxTask_PDS.TabIndex = 0;
            this.groupBoxTask_PDS.TabStop = false;
            this.groupBoxTask_PDS.Text = "Условие:";
            // 
            // labelTaskMatrix_PDS
            // 
            this.labelTaskMatrix_PDS.AutoSize = true;
            this.labelTaskMatrix_PDS.Location = new System.Drawing.Point(6, 235);
            this.labelTaskMatrix_PDS.Name = "labelTaskMatrix_PDS";
            this.labelTaskMatrix_PDS.Size = new System.Drawing.Size(105, 13);
            this.labelTaskMatrix_PDS.TabIndex = 5;
            this.labelTaskMatrix_PDS.Text = "Исходная матрица:";
            // 
            // dataGridViewTaskMatrix_PDS
            // 
            this.dataGridViewTaskMatrix_PDS.AllowUserToAddRows = false;
            this.dataGridViewTaskMatrix_PDS.AllowUserToDeleteRows = false;
            this.dataGridViewTaskMatrix_PDS.AllowUserToResizeColumns = false;
            this.dataGridViewTaskMatrix_PDS.AllowUserToResizeRows = false;
            this.dataGridViewTaskMatrix_PDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTaskMatrix_PDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskMatrix_PDS.ColumnHeadersVisible = false;
            this.dataGridViewTaskMatrix_PDS.Location = new System.Drawing.Point(51, 272);
            this.dataGridViewTaskMatrix_PDS.Name = "dataGridViewTaskMatrix_PDS";
            this.dataGridViewTaskMatrix_PDS.ReadOnly = true;
            this.dataGridViewTaskMatrix_PDS.RowHeadersVisible = false;
            this.dataGridViewTaskMatrix_PDS.Size = new System.Drawing.Size(288, 147);
            this.dataGridViewTaskMatrix_PDS.TabIndex = 4;
            this.dataGridViewTaskMatrix_PDS.TabStop = false;
            // 
            // textBoxTask_PDS
            // 
            this.textBoxTask_PDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PDS.Location = new System.Drawing.Point(6, 16);
            this.textBoxTask_PDS.Multiline = true;
            this.textBoxTask_PDS.Name = "textBoxTask_PDS";
            this.textBoxTask_PDS.ReadOnly = true;
            this.textBoxTask_PDS.Size = new System.Drawing.Size(385, 207);
            this.textBoxTask_PDS.TabIndex = 0;
            this.textBoxTask_PDS.Text = resources.GetString("textBoxTask_PDS.Text");
            // 
            // buttonDone_PDS
            // 
            this.buttonDone_PDS.Location = new System.Drawing.Point(550, 407);
            this.buttonDone_PDS.Name = "buttonDone_PDS";
            this.buttonDone_PDS.Size = new System.Drawing.Size(229, 46);
            this.buttonDone_PDS.TabIndex = 0;
            this.buttonDone_PDS.Text = "Выполнить";
            this.buttonDone_PDS.UseVisualStyleBackColor = true;
            this.buttonDone_PDS.Click += new System.EventHandler(this.buttonDone_PDS_Click);
            // 
            // buttonHelp_PDS
            // 
            this.buttonHelp_PDS.Location = new System.Drawing.Point(424, 407);
            this.buttonHelp_PDS.Name = "buttonHelp_PDS";
            this.buttonHelp_PDS.Size = new System.Drawing.Size(115, 46);
            this.buttonHelp_PDS.TabIndex = 0;
            this.buttonHelp_PDS.Text = "Справка";
            this.buttonHelp_PDS.UseVisualStyleBackColor = true;
            this.buttonHelp_PDS.Click += new System.EventHandler(this.buttonHelp_PDS_Click);
            // 
            // groupBoxOutput_PDS
            // 
            this.groupBoxOutput_PDS.Controls.Add(this.labelResultMatrix_PDS);
            this.groupBoxOutput_PDS.Controls.Add(this.dataGridViewResultMatrix_PDS);
            this.groupBoxOutput_PDS.Location = new System.Drawing.Point(424, 12);
            this.groupBoxOutput_PDS.Name = "groupBoxOutput_PDS";
            this.groupBoxOutput_PDS.Size = new System.Drawing.Size(355, 389);
            this.groupBoxOutput_PDS.TabIndex = 5;
            this.groupBoxOutput_PDS.TabStop = false;
            this.groupBoxOutput_PDS.Text = "Вывод данных:";
            // 
            // labelResultMatrix_PDS
            // 
            this.labelResultMatrix_PDS.AutoSize = true;
            this.labelResultMatrix_PDS.Location = new System.Drawing.Point(6, 16);
            this.labelResultMatrix_PDS.Name = "labelResultMatrix_PDS";
            this.labelResultMatrix_PDS.Size = new System.Drawing.Size(134, 13);
            this.labelResultMatrix_PDS.TabIndex = 0;
            this.labelResultMatrix_PDS.Text = "Сортированная матрица:";
            // 
            // dataGridViewResultMatrix_PDS
            // 
            this.dataGridViewResultMatrix_PDS.AllowUserToAddRows = false;
            this.dataGridViewResultMatrix_PDS.AllowUserToDeleteRows = false;
            this.dataGridViewResultMatrix_PDS.AllowUserToResizeColumns = false;
            this.dataGridViewResultMatrix_PDS.AllowUserToResizeRows = false;
            this.dataGridViewResultMatrix_PDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultMatrix_PDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultMatrix_PDS.ColumnHeadersVisible = false;
            this.dataGridViewResultMatrix_PDS.Location = new System.Drawing.Point(34, 44);
            this.dataGridViewResultMatrix_PDS.Name = "dataGridViewResultMatrix_PDS";
            this.dataGridViewResultMatrix_PDS.ReadOnly = true;
            this.dataGridViewResultMatrix_PDS.RowHeadersVisible = false;
            this.dataGridViewResultMatrix_PDS.Size = new System.Drawing.Size(288, 147);
            this.dataGridViewResultMatrix_PDS.TabIndex = 4;
            this.dataGridViewResultMatrix_PDS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 465);
            this.Controls.Add(this.groupBoxOutput_PDS);
            this.Controls.Add(this.buttonHelp_PDS);
            this.Controls.Add(this.buttonDone_PDS);
            this.Controls.Add(this.groupBoxTask_PDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Помаз Д.С";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PDS.ResumeLayout(false);
            this.groupBoxTask_PDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_PDS)).EndInit();
            this.groupBoxOutput_PDS.ResumeLayout(false);
            this.groupBoxOutput_PDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_PDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PDS;
        private System.Windows.Forms.Button buttonDone_PDS;
        private System.Windows.Forms.Button buttonHelp_PDS;
        private System.Windows.Forms.DataGridView dataGridViewTaskMatrix_PDS;
        private System.Windows.Forms.TextBox textBoxTask_PDS;
        private System.Windows.Forms.Label labelTaskMatrix_PDS;
        private System.Windows.Forms.GroupBox groupBoxOutput_PDS;
        private System.Windows.Forms.Label labelResultMatrix_PDS;
        private System.Windows.Forms.DataGridView dataGridViewResultMatrix_PDS;
    }
}

