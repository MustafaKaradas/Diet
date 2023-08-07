namespace DietProgram.UI.UserUI
{
    partial class frmUserReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserReports));
            dgvWeekly = new DataGridView();
            btnGetReport = new Button();
            dgvMonthly = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvWeekly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthly).BeginInit();
            SuspendLayout();
            // 
            // dgvWeekly
            // 
            dgvWeekly.BackgroundColor = SystemColors.Info;
            dgvWeekly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeekly.Location = new Point(34, 137);
            dgvWeekly.Name = "dgvWeekly";
            dgvWeekly.RowTemplate.Height = 25;
            dgvWeekly.Size = new Size(623, 612);
            dgvWeekly.TabIndex = 0;
            // 
            // btnGetReport
            // 
            btnGetReport.Location = new Point(663, 374);
            btnGetReport.Name = "btnGetReport";
            btnGetReport.Size = new Size(82, 48);
            btnGetReport.TabIndex = 4;
            btnGetReport.Text = "Rapor Getir";
            btnGetReport.UseVisualStyleBackColor = true;
            btnGetReport.Click += btnRaporGetir_Click;
            // 
            // dgvMonthly
            // 
            dgvMonthly.BackgroundColor = SystemColors.Info;
            dgvMonthly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthly.Location = new Point(751, 137);
            dgvMonthly.Name = "dgvMonthly";
            dgvMonthly.RowTemplate.Height = 25;
            dgvMonthly.Size = new Size(621, 612);
            dgvMonthly.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(265, 111);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 6;
            label1.Text = "Haftalık Rapor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1038, 111);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 7;
            label2.Text = "Aylık Rapor";
            // 
            // frmUserReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 761);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMonthly);
            Controls.Add(btnGetReport);
            Controls.Add(dgvWeekly);
            DoubleBuffered = true;
            Name = "frmUserReports";
            Text = "frmUserReports";
            Load += frmUserReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWeekly).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthly).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWeekly;
        private Button btnGetReport;
        private DataGridView dgvMonthly;
        private Label label1;
        private Label label2;
    }
}