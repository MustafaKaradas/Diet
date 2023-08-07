namespace DietProgram.UI.AppUI
{
    partial class frmCreateNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewUser));
            lblnecessary = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblnecessary1 = new Label();
            lblnecessary2 = new Label();
            lbltxtSecurityCode = new Label();
            lblPasswordConfirm = new Label();
            txtSecurityCode = new TextBox();
            txtPassword = new TextBox();
            btnCreateNewUser = new Button();
            btnLogOut4 = new Button();
            btnBack = new Button();
            btnSoru = new Button();
            lblDescription = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblnecessary
            // 
            lblnecessary.AutoSize = true;
            lblnecessary.BackColor = Color.Transparent;
            lblnecessary.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary.ForeColor = Color.Red;
            lblnecessary.Location = new Point(990, 232);
            lblnecessary.Name = "lblnecessary";
            lblnecessary.Size = new Size(17, 19);
            lblnecessary.TabIndex = 48;
            lblnecessary.Text = "*";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(365, 206);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(117, 23);
            lblUserName.TabIndex = 47;
            lblUserName.Text = "Kullanıcı Adı :";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ScrollBar;
            txtUserName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(365, 232);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(619, 39);
            txtUserName.TabIndex = 46;
            // 
            // lblnecessary1
            // 
            lblnecessary1.AutoSize = true;
            lblnecessary1.BackColor = Color.Transparent;
            lblnecessary1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary1.ForeColor = Color.Red;
            lblnecessary1.Location = new Point(990, 322);
            lblnecessary1.Name = "lblnecessary1";
            lblnecessary1.Size = new Size(17, 19);
            lblnecessary1.TabIndex = 44;
            lblnecessary1.Text = "*";
            // 
            // lblnecessary2
            // 
            lblnecessary2.AutoSize = true;
            lblnecessary2.BackColor = Color.Transparent;
            lblnecessary2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnecessary2.ForeColor = Color.Red;
            lblnecessary2.Location = new Point(990, 400);
            lblnecessary2.Name = "lblnecessary2";
            lblnecessary2.Size = new Size(17, 19);
            lblnecessary2.TabIndex = 45;
            lblnecessary2.Text = "*";
            // 
            // lbltxtSecurityCode
            // 
            lbltxtSecurityCode.AutoSize = true;
            lbltxtSecurityCode.BackColor = Color.Transparent;
            lbltxtSecurityCode.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltxtSecurityCode.Location = new Point(365, 392);
            lbltxtSecurityCode.Name = "lbltxtSecurityCode";
            lbltxtSecurityCode.Size = new Size(129, 23);
            lbltxtSecurityCode.TabIndex = 42;
            lbltxtSecurityCode.Text = "Güvenlik Kodu:";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.BackColor = Color.Transparent;
            lblPasswordConfirm.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordConfirm.Location = new Point(365, 296);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(56, 23);
            lblPasswordConfirm.TabIndex = 43;
            lblPasswordConfirm.Text = "Şifre :";
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.BackColor = SystemColors.ScrollBar;
            txtSecurityCode.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecurityCode.Location = new Point(365, 418);
            txtSecurityCode.Multiline = true;
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.Size = new Size(619, 39);
            txtSecurityCode.TabIndex = 40;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(365, 322);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(619, 39);
            txtPassword.TabIndex = 41;
            // 
            // btnCreateNewUser
            // 
            btnCreateNewUser.BackColor = SystemColors.Control;
            btnCreateNewUser.BackgroundImage = (Image)resources.GetObject("btnCreateNewUser.BackgroundImage");
            btnCreateNewUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateNewUser.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateNewUser.ForeColor = Color.White;
            btnCreateNewUser.Location = new Point(564, 496);
            btnCreateNewUser.Name = "btnCreateNewUser";
            btnCreateNewUser.Size = new Size(222, 58);
            btnCreateNewUser.TabIndex = 39;
            btnCreateNewUser.Text = "Yeni Kullanıcı Oluştur";
            btnCreateNewUser.UseVisualStyleBackColor = false;
            btnCreateNewUser.Click += btnCreateNewUser_Click;
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
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 740);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 73;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSoru
            // 
            btnSoru.BackColor = SystemColors.ButtonShadow;
            btnSoru.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoru.Location = new Point(990, 427);
            btnSoru.Name = "btnSoru";
            btnSoru.Size = new Size(42, 30);
            btnSoru.TabIndex = 74;
            btnSoru.Text = "?";
            btnSoru.UseVisualStyleBackColor = false;
            btnSoru.Click += btnSoru_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Red;
            lblDescription.Location = new Point(365, 471);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 23);
            lblDescription.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1013, 309);
            label1.Name = "label1";
            label1.Size = new Size(189, 52);
            label1.TabIndex = 76;
            label1.Text = "En az 8 karakter uzunluğunda olmalıdır.\r\nEn az 2 büyük harf içermelidir.\r\nEn az 3 küçük harf içermelidir.\r\nEn az 1 özel karakter içermelidir.";
            // 
            // frmCreateNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(label1);
            Controls.Add(lblDescription);
            Controls.Add(btnSoru);
            Controls.Add(btnBack);
            Controls.Add(btnLogOut4);
            Controls.Add(lblnecessary);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(lblnecessary1);
            Controls.Add(lblnecessary2);
            Controls.Add(lbltxtSecurityCode);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(txtSecurityCode);
            Controls.Add(txtPassword);
            Controls.Add(btnCreateNewUser);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1013, 418);
            Name = "frmCreateNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCreateNewUser";
            Load += frmCreateNewUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblnecessary;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblnecessary1;
        private Label lblnecessary2;
        private Label lbltxtSecurityCode;
        private Label lblPasswordConfirm;
        private TextBox txtPassword;
        private Button btnCreateNewUser;
        private Button btnLogOut4;
        private Button btnBack;
        private TextBox txtSecurityCode;
        private Button btnSoru;
        private Label lblDescription;
        private Label label1;
    }
}