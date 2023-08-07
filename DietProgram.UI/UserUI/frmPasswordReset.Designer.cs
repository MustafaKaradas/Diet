namespace DietProgram.UI.UserUI
{
    partial class frmPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordReset));
            this.lblnecessary2 = new System.Windows.Forms.Label();
            this.lblnecessary3 = new System.Windows.Forms.Label();
            this.lblnecessary = new System.Windows.Forms.Label();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnecessary2
            // 
            this.lblnecessary2.AutoSize = true;
            this.lblnecessary2.BackColor = System.Drawing.Color.Transparent;
            this.lblnecessary2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnecessary2.ForeColor = System.Drawing.Color.Red;
            this.lblnecessary2.Location = new System.Drawing.Point(996, 377);
            this.lblnecessary2.Name = "lblnecessary2";
            this.lblnecessary2.Size = new System.Drawing.Size(17, 19);
            this.lblnecessary2.TabIndex = 29;
            this.lblnecessary2.Text = "*";
            // 
            // lblnecessary3
            // 
            this.lblnecessary3.AutoSize = true;
            this.lblnecessary3.BackColor = System.Drawing.Color.Transparent;
            this.lblnecessary3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnecessary3.ForeColor = System.Drawing.Color.Red;
            this.lblnecessary3.Location = new System.Drawing.Point(996, 468);
            this.lblnecessary3.Name = "lblnecessary3";
            this.lblnecessary3.Size = new System.Drawing.Size(17, 19);
            this.lblnecessary3.TabIndex = 30;
            this.lblnecessary3.Text = "*";
            // 
            // lblnecessary
            // 
            this.lblnecessary.AutoSize = true;
            this.lblnecessary.BackColor = System.Drawing.Color.Transparent;
            this.lblnecessary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnecessary.ForeColor = System.Drawing.Color.Red;
            this.lblnecessary.Location = new System.Drawing.Point(996, 289);
            this.lblnecessary.Name = "lblnecessary";
            this.lblnecessary.Size = new System.Drawing.Size(17, 19);
            this.lblnecessary.TabIndex = 31;
            this.lblnecessary.Text = "*";
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurityCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecurityCode.Location = new System.Drawing.Point(371, 254);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(124, 23);
            this.lblSecurityCode.TabIndex = 26;
            this.lblSecurityCode.Text = "Güvenlik Kodu";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(371, 351);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 23);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Şifre :";
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordConfirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordConfirm.Location = new System.Drawing.Point(371, 442);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(105, 23);
            this.lblPasswordConfirm.TabIndex = 28;
            this.lblPasswordConfirm.Text = "Şifre Tekrar:";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSecurityCode.Enabled = false;
            this.txtSecurityCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecurityCode.Location = new System.Drawing.Point(371, 289);
            this.txtSecurityCode.Multiline = true;
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(619, 39);
            this.txtSecurityCode.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(371, 377);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(619, 39);
            this.txtPassword.TabIndex = 24;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordConfirm.Location = new System.Drawing.Point(371, 468);
            this.txtPasswordConfirm.Multiline = true;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(619, 39);
            this.txtPasswordConfirm.TabIndex = 25;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(1358, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(30, 30);
            this.btnLogOut.TabIndex = 32;
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
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1219, 730);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 58);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblnecessary2);
            this.Controls.Add(this.lblnecessary3);
            this.Controls.Add(this.lblnecessary);
            this.Controls.Add(this.lblSecurityCode);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPasswordConfirm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPasswordReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnecessary2;
        private Label lblnecessary3;
        private Label lblnecessary;
        private Label lblSecurityCode;
        private Label lblPassword;
        private Label lblPasswordConfirm;
        private TextBox txtSecurityCode;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Button btnLogOut;
        private Button btnBack;
        private Button btnSave;
    }
}