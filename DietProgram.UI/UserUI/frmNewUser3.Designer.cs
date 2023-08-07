namespace DietProgram.UI.AppUI
{
    partial class frmNewUser3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser3));
            lblnecessary = new Label();
            lblHowActiveAreYou = new Label();
            btnActive = new Button();
            btnMidActive = new Button();
            btnLessActive = new Button();
            btnLogOut4 = new Button();
            SuspendLayout();
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(914, 247);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 63;
            lblnecessary.Text = "*";
            // 
            // lblHowActiveAreYou
            // 
            lblHowActiveAreYou.AutoSize = true;
            lblHowActiveAreYou.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHowActiveAreYou.Location = new Point(429, 247);
            lblHowActiveAreYou.Name = "lblHowActiveAreYou";
            lblHowActiveAreYou.Size = new Size(479, 59);
            lblHowActiveAreYou.TabIndex = 62;
            lblHowActiveAreYou.Text = "Ne Kadar Hareketlisin?";
            // 
            // btnActive
            // 
            btnActive.BackgroundImage = (Image)resources.GetObject("btnActive.BackgroundImage");
            btnActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnActive.DialogResult = DialogResult.Abort;
            btnActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnActive.ForeColor = Color.White;
            btnActive.Location = new Point(951, 445);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(192, 69);
            btnActive.TabIndex = 59;
            btnActive.Text = "Çok Hareketli";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // btnMidActive
            // 
            btnMidActive.BackgroundImage = (Image)resources.GetObject("btnMidActive.BackgroundImage");
            btnMidActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnMidActive.DialogResult = DialogResult.Abort;
            btnMidActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMidActive.ForeColor = Color.White;
            btnMidActive.Location = new Point(540, 445);
            btnMidActive.Name = "btnMidActive";
            btnMidActive.Size = new Size(290, 69);
            btnMidActive.TabIndex = 60;
            btnMidActive.Text = "Orta Derece Hareketli";
            btnMidActive.UseVisualStyleBackColor = true;
            btnMidActive.Click += btnMidActive_Click;
            // 
            // btnLessActive
            // 
            btnLessActive.BackgroundImage = (Image)resources.GetObject("btnLessActive.BackgroundImage");
            btnLessActive.BackgroundImageLayout = ImageLayout.Stretch;
            btnLessActive.DialogResult = DialogResult.Abort;
            btnLessActive.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLessActive.ForeColor = Color.White;
            btnLessActive.Location = new Point(241, 445);
            btnLessActive.Name = "btnLessActive";
            btnLessActive.Size = new Size(181, 69);
            btnLessActive.TabIndex = 61;
            btnLessActive.Text = "Az Hareketli";
            btnLessActive.UseVisualStyleBackColor = true;
            btnLessActive.Click += btnLessActive_Click;
            // 
            // btnLogOut4
            // 
            btnLogOut4.BackColor = Color.Transparent;
            btnLogOut4.BackgroundImage = (Image)resources.GetObject("btnLogOut4.BackgroundImage");
            btnLogOut4.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut4.Location = new Point(1358, 12);
            btnLogOut4.Name = "btnLogOut4";
            btnLogOut4.Size = new Size(30, 30);
            btnLogOut4.TabIndex = 72;
            btnLogOut4.UseVisualStyleBackColor = false;
            btnLogOut4.Click += btnLogOut4_Click;
            // 
            // frmNewUser3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(btnLogOut4);
            Controls.Add(lblnecessary);
            Controls.Add(lblHowActiveAreYou);
            Controls.Add(btnActive);
            Controls.Add(btnMidActive);
            Controls.Add(btnLessActive);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewUser3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNewUser3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnecessary;
        private Label lblHowActiveAreYou;
        private Button btnActive;
        private Button btnMidActive;
        private Button btnLessActive;
        private Button btnLogOut4;
    }
}