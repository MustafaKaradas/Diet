namespace DietProgram.UI.AdminUI
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut1 = new System.Windows.Forms.Button();
            this.lblControl = new System.Windows.Forms.Label();
            this.lblnecessary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(383, 296);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(383, 333);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(619, 39);
            this.txtPassword.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(607, 407);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 58);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Oturum Aç";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 740);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 48);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut1
            // 
            this.btnLogOut1.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut1.BackgroundImage")));
            this.btnLogOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut1.Location = new System.Drawing.Point(1358, 12);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(30, 30);
            this.btnLogOut1.TabIndex = 11;
            this.btnLogOut1.UseVisualStyleBackColor = false;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut1_Click);
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.BackColor = System.Drawing.Color.Transparent;
            this.lblControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblControl.ForeColor = System.Drawing.Color.Black;
            this.lblControl.Location = new System.Drawing.Point(383, 375);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(0, 23);
            this.lblControl.TabIndex = 12;
            // 
            // lblnecessary
            // 
            this.lblnecessary.AutoSize = true;
            this.lblnecessary.BackColor = System.Drawing.Color.Transparent;
            this.lblnecessary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnecessary.ForeColor = System.Drawing.Color.Red;
            this.lblnecessary.Location = new System.Drawing.Point(1008, 333);
            this.lblnecessary.Name = "lblnecessary";
            this.lblnecessary.Size = new System.Drawing.Size(17, 19);
            this.lblnecessary.TabIndex = 49;
            this.lblnecessary.Text = "*";
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lblnecessary);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.btnLogOut1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBack;
        private Button btnLogOut1;
        private Label lblControl;
        private Label lblnecessary;
    }
}