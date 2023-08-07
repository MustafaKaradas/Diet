namespace DietProgram.UI.AppUI
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogOut4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminLogin.BackgroundImage")));
            this.btnAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(1226, 52);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(106, 37);
            this.btnAdminLogin.TabIndex = 6;
            this.btnAdminLogin.Text = "Admin Giriş";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewUser.BackgroundImage")));
            this.btnNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(999, 460);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(169, 58);
            this.btnNewUser.TabIndex = 5;
            this.btnNewUser.Text = "Yeni Kullanıcı Oluştur";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(999, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 58);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Oturum Aç";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogOut4
            // 
            this.btnLogOut4.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut4.BackgroundImage")));
            this.btnLogOut4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut4.Location = new System.Drawing.Point(1355, 12);
            this.btnLogOut4.Name = "btnLogOut4";
            this.btnLogOut4.Size = new System.Drawing.Size(33, 30);
            this.btnLogOut4.TabIndex = 72;
            this.btnLogOut4.UseVisualStyleBackColor = false;
            this.btnLogOut4.Click += new System.EventHandler(this.btnLogOut4_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.btnLogOut4);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainPage";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAdminLogin;
        private Button btnNewUser;
        private Button btnLogin;
        private Button btnLogOut4;
    }
}