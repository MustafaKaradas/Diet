namespace DietProgram.UI.UserUI
{
    partial class frmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
            btnSaveInfo = new Button();
            lblHowActiveAreYou = new Label();
            lblHipCircumference = new Label();
            lblNeckCircumference = new Label();
            lblWaistCircumference = new Label();
            txtHipCircumference = new TextBox();
            txtNeckCircumference = new TextBox();
            txtWaistCircumference = new TextBox();
            lblWeight = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblName = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            lblGender = new Label();
            checkBoxMale = new CheckBox();
            checkBoxFemale = new CheckBox();
            btnBack = new Button();
            btnLogOut = new Button();
            rbLess = new RadioButton();
            rbMid = new RadioButton();
            rbVery = new RadioButton();
            SuspendLayout();
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.BackgroundImage = (Image)resources.GetObject("btnSaveInfo.BackgroundImage");
            btnSaveInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveInfo.DialogResult = DialogResult.Abort;
            btnSaveInfo.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveInfo.ForeColor = Color.White;
            btnSaveInfo.Location = new Point(1227, 740);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(161, 48);
            btnSaveInfo.TabIndex = 84;
            btnSaveInfo.Text = "Bilgileri Kaydet...";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // lblHowActiveAreYou
            // 
            lblHowActiveAreYou.AutoSize = true;
            lblHowActiveAreYou.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblHowActiveAreYou.Location = new Point(503, 581);
            lblHowActiveAreYou.Name = "lblHowActiveAreYou";
            lblHowActiveAreYou.Size = new Size(300, 37);
            lblHowActiveAreYou.TabIndex = 83;
            lblHowActiveAreYou.Text = "Ne Kadar Hareketlisin?";
            // 
            // lblHipCircumference
            // 
            lblHipCircumference.AutoSize = true;
            lblHipCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHipCircumference.Location = new Point(364, 501);
            lblHipCircumference.Name = "lblHipCircumference";
            lblHipCircumference.Size = new Size(123, 23);
            lblHipCircumference.TabIndex = 79;
            lblHipCircumference.Text = "Kalça Çevresi :";
            // 
            // lblNeckCircumference
            // 
            lblNeckCircumference.AutoSize = true;
            lblNeckCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNeckCircumference.Location = new Point(319, 445);
            lblNeckCircumference.Name = "lblNeckCircumference";
            lblNeckCircumference.Size = new Size(171, 23);
            lblNeckCircumference.TabIndex = 78;
            lblNeckCircumference.Text = "Boyun Çevresi (cm) :";
            // 
            // lblWaistCircumference
            // 
            lblWaistCircumference.AutoSize = true;
            lblWaistCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWaistCircumference.Location = new Point(343, 383);
            lblWaistCircumference.Name = "lblWaistCircumference";
            lblWaistCircumference.Size = new Size(147, 23);
            lblWaistCircumference.TabIndex = 77;
            lblWaistCircumference.Text = "Bel Çevresi (cm) :";
            // 
            // txtHipCircumference
            // 
            txtHipCircumference.BackColor = SystemColors.ScrollBar;
            txtHipCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHipCircumference.Location = new Point(503, 504);
            txtHipCircumference.Multiline = true;
            txtHipCircumference.Name = "txtHipCircumference";
            txtHipCircumference.Size = new Size(386, 27);
            txtHipCircumference.TabIndex = 74;
            // 
            // txtNeckCircumference
            // 
            txtNeckCircumference.BackColor = SystemColors.ScrollBar;
            txtNeckCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNeckCircumference.Location = new Point(504, 448);
            txtNeckCircumference.Multiline = true;
            txtNeckCircumference.Name = "txtNeckCircumference";
            txtNeckCircumference.Size = new Size(386, 27);
            txtNeckCircumference.TabIndex = 75;
            // 
            // txtWaistCircumference
            // 
            txtWaistCircumference.BackColor = SystemColors.ScrollBar;
            txtWaistCircumference.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWaistCircumference.Location = new Point(504, 386);
            txtWaistCircumference.Multiline = true;
            txtWaistCircumference.Name = "txtWaistCircumference";
            txtWaistCircumference.Size = new Size(386, 27);
            txtWaistCircumference.TabIndex = 76;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.Location = new Point(438, 323);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(49, 23);
            lblWeight.TabIndex = 72;
            lblWeight.Text = "Kilo :";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.Location = new Point(438, 271);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(49, 23);
            lblHeight.TabIndex = 73;
            lblHeight.Text = "Boy :";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(438, 219);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(45, 23);
            lblAge.TabIndex = 71;
            lblAge.Text = "Yaş :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(438, 167);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 23);
            lblName.TabIndex = 70;
            lblName.Text = "İsim :";
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.ScrollBar;
            txtWeight.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWeight.Location = new Point(503, 326);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(386, 31);
            txtWeight.TabIndex = 66;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.ScrollBar;
            txtHeight.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHeight.Location = new Point(503, 274);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(386, 31);
            txtHeight.TabIndex = 67;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.ScrollBar;
            txtAge.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(504, 219);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(386, 31);
            txtAge.TabIndex = 68;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(504, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(386, 31);
            txtName.TabIndex = 69;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(396, 129);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(94, 27);
            lblGender.TabIndex = 65;
            lblGender.Text = "Cinsiyet :";
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMale.Location = new Point(669, 125);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(80, 31);
            checkBoxMale.TabIndex = 63;
            checkBoxMale.Text = "Erkek";
            checkBoxMale.UseVisualStyleBackColor = true;
            checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged;
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFemale.Location = new Point(567, 125);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(82, 31);
            checkBoxFemale.TabIndex = 64;
            checkBoxFemale.Text = "Kadın";
            checkBoxFemale.UseVisualStyleBackColor = true;
            checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 740);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 85;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(1358, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(30, 30);
            btnLogOut.TabIndex = 86;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.BackColor = Color.Transparent;
            rbLess.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbLess.Location = new Point(438, 653);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(119, 27);
            rbLess.TabIndex = 87;
            rbLess.TabStop = true;
            rbLess.Text = "Az Hareketli";
            rbLess.UseVisualStyleBackColor = false;
            // 
            // rbMid
            // 
            rbMid.AutoSize = true;
            rbMid.BackColor = Color.Transparent;
            rbMid.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbMid.Location = new Point(563, 653);
            rbMid.Name = "rbMid";
            rbMid.Size = new Size(193, 27);
            rbMid.TabIndex = 88;
            rbMid.TabStop = true;
            rbMid.Text = "Orta Derece Hareketli";
            rbMid.UseVisualStyleBackColor = false;
            // 
            // rbVery
            // 
            rbVery.AutoSize = true;
            rbVery.BackColor = Color.Transparent;
            rbVery.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbVery.Location = new Point(762, 653);
            rbVery.Name = "rbVery";
            rbVery.Size = new Size(129, 27);
            rbVery.TabIndex = 89;
            rbVery.TabStop = true;
            rbVery.Text = "Çok Hareketli";
            rbVery.UseVisualStyleBackColor = false;
            // 
            // frmUserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(rbVery);
            Controls.Add(rbMid);
            Controls.Add(rbLess);
            Controls.Add(btnLogOut);
            Controls.Add(btnBack);
            Controls.Add(btnSaveInfo);
            Controls.Add(lblHowActiveAreYou);
            Controls.Add(lblHipCircumference);
            Controls.Add(lblNeckCircumference);
            Controls.Add(lblWaistCircumference);
            Controls.Add(txtHipCircumference);
            Controls.Add(txtNeckCircumference);
            Controls.Add(txtWaistCircumference);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(checkBoxMale);
            Controls.Add(checkBoxFemale);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserProfile";
            Load += frmUserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveInfo;
        private Label lblHowActiveAreYou;
        private Label lblHipCircumference;
        private Label lblNeckCircumference;
        private Label lblWaistCircumference;
        private TextBox txtHipCircumference;
        private TextBox txtNeckCircumference;
        private TextBox txtWaistCircumference;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblAge;
        private Label lblName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtAge;
        private TextBox txtName;
        private Label lblGender;
        private CheckBox checkBoxMale;
        private CheckBox checkBoxFemale;
        private Button btnBack;
        private Button btnLogOut;
        private RadioButton rbLess;
        private RadioButton rbMid;
        private RadioButton rbVery;
    }
}