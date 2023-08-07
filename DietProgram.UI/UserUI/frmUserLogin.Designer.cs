namespace DietProgram.UI
{
    partial class frmUserLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
            this.lblnecessary3 = new System.Windows.Forms.Label();
            this.lblnecessary2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnecessary3
            // 
            this.lblnecessary3.AutoSize = true;
            this.lblnecessary3.BackColor = System.Drawing.Color.Transparent;
            this.lblnecessary3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnecessary3.ForeColor = System.Drawing.Color.Red;
            this.lblnecessary3.Location = new System.Drawing.Point(996, 384);
            this.lblnecessary3.Name = "lblnecessary3";
            this.lblnecessary3.Size = new System.Drawing.Size(17, 19);
            this.lblnecessary3.TabIndex = 20;
            this.lblnecessary3.Text = "*";
            // 
            // lblnecessary2
            // 
            this.lblnecessary2.AutoSize = true;
            this.lblnecessary2.BackColor = System.Drawing.Color.Transparent;
            this.lblnecessary2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnecessary2.ForeColor = System.Drawing.Color.Red;
            this.lblnecessary2.Location = new System.Drawing.Point(996, 282);
            this.lblnecessary2.Name = "lblnecessary2";
            this.lblnecessary2.Size = new System.Drawing.Size(17, 19);
            this.lblnecessary2.TabIndex = 21;
            this.lblnecessary2.Text = "*";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(371, 243);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 23);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "Kullanıcı Adı :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(371, 349);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 23);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Şifre :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(371, 282);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(619, 39);
            this.txtUserName.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(371, 384);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(619, 39);
            this.txtPassword.TabIndex = 17;
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnForgotPassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForgotPassword.Location = new System.Drawing.Point(371, 429);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(156, 27);
            this.btnForgotPassword.TabIndex = 15;
            this.btnForgotPassword.Text = "Şifremi Unuttum";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnLogin2
            // 
            this.btnLogin2.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin2.BackgroundImage")));
            this.btnLogin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin2.ForeColor = System.Drawing.Color.White;
            this.btnLogin2.Location = new System.Drawing.Point(597, 460);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(169, 58);
            this.btnLogin2.TabIndex = 14;
            this.btnLogin2.Text = "Oturum Aç";
            this.btnLogin2.UseVisualStyleBackColor = false;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(1358, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(30, 30);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 740);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 48);
            this.btnBack.TabIndex = 86;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblnecessary3);
            this.Controls.Add(this.lblnecessary2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnLogin2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnecessary3;
        private Label lblnecessary2;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnForgotPassword;
        private Button btnLogin2;
        private Button btnLogOut;
        private Button btnBack;
    }
}