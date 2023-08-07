namespace DietProgram.UI.AppUI
{
    partial class frmAppMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppMainPage));
            btnDinner = new Button();
            btnLunch = new Button();
            btnSnacks = new Button();
            btnBreakfast = new Button();
            lblBreakfast = new Label();
            panelforAppMainPage = new Panel();
            lblYağ = new Label();
            lblCarbon = new Label();
            lblPro = new Label();
            label9 = new Label();
            lblTotalCal = new Label();
            lblTakenCal = new Label();
            lblAyFavori = new Label();
            lblHaftaFavori = new Label();
            lblAksam = new Label();
            lblÖğle = new Label();
            lblAraÖğün = new Label();
            lblKahvaltı = new Label();
            lblFat = new Label();
            lblCarbohydrate = new Label();
            lblProtein = new Label();
            lblCalorie2 = new Label();
            lblCalorie = new Label();
            lblkcal2 = new Label();
            lblDailyTotalcal = new Label();
            lblWeeklyFav = new Label();
            lblDinner = new Label();
            lblMonthlyFav = new Label();
            lblLunch = new Label();
            lblCalorie4 = new Label();
            lblSnack = new Label();
            pictureBox1 = new PictureBox();
            btnLogOut1 = new Button();
            dgv_BreakFast = new DataGridView();
            dgv_Snacks = new DataGridView();
            dgv_Lunch = new DataGridView();
            dgv_Dinner = new DataGridView();
            btnRapor = new Button();
            panelforAppMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_BreakFast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Snacks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Lunch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Dinner).BeginInit();
            SuspendLayout();
            // 
            // btnDinner
            // 
            btnDinner.BackgroundImage = (Image)resources.GetObject("btnDinner.BackgroundImage");
            btnDinner.BackgroundImageLayout = ImageLayout.Stretch;
            btnDinner.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDinner.Location = new Point(787, 587);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(133, 33);
            btnDinner.TabIndex = 97;
            btnDinner.Text = "Akşam Yemeği";
            btnDinner.UseVisualStyleBackColor = true;
            btnDinner.Click += btnDinner_Click;
            // 
            // btnLunch
            // 
            btnLunch.BackgroundImage = (Image)resources.GetObject("btnLunch.BackgroundImage");
            btnLunch.BackgroundImageLayout = ImageLayout.Stretch;
            btnLunch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLunch.Location = new Point(327, 587);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(121, 33);
            btnLunch.TabIndex = 96;
            btnLunch.Text = "Öğle Yemeği";
            btnLunch.UseVisualStyleBackColor = true;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnSnacks
            // 
            btnSnacks.BackgroundImage = (Image)resources.GetObject("btnSnacks.BackgroundImage");
            btnSnacks.BackgroundImageLayout = ImageLayout.Stretch;
            btnSnacks.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSnacks.Location = new Point(787, 411);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(121, 33);
            btnSnacks.TabIndex = 95;
            btnSnacks.Text = "Ara Öğün";
            btnSnacks.UseVisualStyleBackColor = true;
            btnSnacks.Click += btnSnacks_Click;
            // 
            // btnBreakfast
            // 
            btnBreakfast.BackgroundImage = (Image)resources.GetObject("btnBreakfast.BackgroundImage");
            btnBreakfast.BackgroundImageLayout = ImageLayout.Stretch;
            btnBreakfast.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBreakfast.Location = new Point(327, 411);
            btnBreakfast.Name = "btnBreakfast";
            btnBreakfast.Size = new Size(121, 33);
            btnBreakfast.TabIndex = 94;
            btnBreakfast.Text = "Kahvaltı";
            btnBreakfast.UseVisualStyleBackColor = true;
            btnBreakfast.Click += btnBreakfast_Click;
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.BackColor = Color.Transparent;
            lblBreakfast.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBreakfast.Location = new Point(54, 36);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(72, 23);
            lblBreakfast.TabIndex = 92;
            lblBreakfast.Text = "Kahvaltı";
            // 
            // panelforAppMainPage
            // 
            panelforAppMainPage.BackgroundImage = (Image)resources.GetObject("panelforAppMainPage.BackgroundImage");
            panelforAppMainPage.Controls.Add(lblYağ);
            panelforAppMainPage.Controls.Add(lblCarbon);
            panelforAppMainPage.Controls.Add(lblPro);
            panelforAppMainPage.Controls.Add(label9);
            panelforAppMainPage.Controls.Add(lblTotalCal);
            panelforAppMainPage.Controls.Add(lblTakenCal);
            panelforAppMainPage.Controls.Add(lblAyFavori);
            panelforAppMainPage.Controls.Add(lblHaftaFavori);
            panelforAppMainPage.Controls.Add(lblAksam);
            panelforAppMainPage.Controls.Add(lblÖğle);
            panelforAppMainPage.Controls.Add(lblAraÖğün);
            panelforAppMainPage.Controls.Add(lblKahvaltı);
            panelforAppMainPage.Controls.Add(lblFat);
            panelforAppMainPage.Controls.Add(lblCarbohydrate);
            panelforAppMainPage.Controls.Add(lblBreakfast);
            panelforAppMainPage.Controls.Add(lblProtein);
            panelforAppMainPage.Controls.Add(lblCalorie2);
            panelforAppMainPage.Controls.Add(lblCalorie);
            panelforAppMainPage.Controls.Add(lblkcal2);
            panelforAppMainPage.Controls.Add(lblDailyTotalcal);
            panelforAppMainPage.Controls.Add(lblWeeklyFav);
            panelforAppMainPage.Controls.Add(lblDinner);
            panelforAppMainPage.Controls.Add(lblMonthlyFav);
            panelforAppMainPage.Controls.Add(lblLunch);
            panelforAppMainPage.Controls.Add(lblCalorie4);
            panelforAppMainPage.Controls.Add(lblSnack);
            panelforAppMainPage.Location = new Point(49, 124);
            panelforAppMainPage.Name = "panelforAppMainPage";
            panelforAppMainPage.Size = new Size(1253, 281);
            panelforAppMainPage.TabIndex = 93;
            // 
            // lblYağ
            // 
            lblYağ.AutoSize = true;
            lblYağ.BackColor = Color.Transparent;
            lblYağ.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblYağ.Location = new Point(1048, 202);
            lblYağ.Name = "lblYağ";
            lblYağ.Size = new Size(110, 23);
            lblYağ.TabIndex = 99;
            lblYağ.Text = "....................";
            lblYağ.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCarbon
            // 
            lblCarbon.AutoSize = true;
            lblCarbon.BackColor = Color.Transparent;
            lblCarbon.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarbon.Location = new Point(866, 202);
            lblCarbon.Name = "lblCarbon";
            lblCarbon.Size = new Size(110, 23);
            lblCarbon.TabIndex = 98;
            lblCarbon.Text = "....................";
            lblCarbon.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.BackColor = Color.Transparent;
            lblPro.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPro.Location = new Point(667, 202);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(110, 23);
            lblPro.TabIndex = 97;
            lblPro.Text = "....................";
            lblPro.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(921, 86);
            label9.Name = "label9";
            label9.Size = new Size(17, 23);
            label9.TabIndex = 96;
            label9.Text = "/";
            // 
            // lblTotalCal
            // 
            lblTotalCal.AutoSize = true;
            lblTotalCal.BackColor = Color.Transparent;
            lblTotalCal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCal.Location = new Point(944, 86);
            lblTotalCal.Name = "lblTotalCal";
            lblTotalCal.Size = new Size(110, 23);
            lblTotalCal.TabIndex = 95;
            lblTotalCal.Text = "....................";
            // 
            // lblTakenCal
            // 
            lblTakenCal.AutoSize = true;
            lblTakenCal.BackColor = Color.Transparent;
            lblTakenCal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTakenCal.Location = new Point(805, 86);
            lblTakenCal.Name = "lblTakenCal";
            lblTakenCal.Size = new Size(110, 23);
            lblTakenCal.TabIndex = 94;
            lblTakenCal.Text = "....................";
            lblTakenCal.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAyFavori
            // 
            lblAyFavori.AutoSize = true;
            lblAyFavori.BackColor = Color.Transparent;
            lblAyFavori.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAyFavori.Location = new Point(218, 233);
            lblAyFavori.Name = "lblAyFavori";
            lblAyFavori.Size = new Size(110, 23);
            lblAyFavori.TabIndex = 93;
            lblAyFavori.Text = "....................";
            lblAyFavori.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHaftaFavori
            // 
            lblHaftaFavori.AutoSize = true;
            lblHaftaFavori.BackColor = Color.Transparent;
            lblHaftaFavori.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHaftaFavori.Location = new Point(218, 199);
            lblHaftaFavori.Name = "lblHaftaFavori";
            lblHaftaFavori.Size = new Size(110, 23);
            lblHaftaFavori.TabIndex = 92;
            lblHaftaFavori.Text = "....................";
            lblHaftaFavori.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAksam
            // 
            lblAksam.AutoSize = true;
            lblAksam.BackColor = Color.Transparent;
            lblAksam.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAksam.Location = new Point(218, 144);
            lblAksam.Name = "lblAksam";
            lblAksam.Size = new Size(110, 23);
            lblAksam.TabIndex = 91;
            lblAksam.Text = "....................";
            lblAksam.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblÖğle
            // 
            lblÖğle.AutoSize = true;
            lblÖğle.BackColor = Color.Transparent;
            lblÖğle.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblÖğle.Location = new Point(218, 108);
            lblÖğle.Name = "lblÖğle";
            lblÖğle.Size = new Size(110, 23);
            lblÖğle.TabIndex = 90;
            lblÖğle.Text = "....................";
            lblÖğle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAraÖğün
            // 
            lblAraÖğün.AutoSize = true;
            lblAraÖğün.BackColor = Color.Transparent;
            lblAraÖğün.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAraÖğün.Location = new Point(218, 69);
            lblAraÖğün.Name = "lblAraÖğün";
            lblAraÖğün.Size = new Size(110, 23);
            lblAraÖğün.TabIndex = 89;
            lblAraÖğün.Text = "....................";
            lblAraÖğün.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblKahvaltı
            // 
            lblKahvaltı.AutoSize = true;
            lblKahvaltı.BackColor = Color.Transparent;
            lblKahvaltı.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblKahvaltı.Location = new Point(218, 36);
            lblKahvaltı.Name = "lblKahvaltı";
            lblKahvaltı.Size = new Size(110, 23);
            lblKahvaltı.TabIndex = 88;
            lblKahvaltı.Text = "....................";
            lblKahvaltı.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFat
            // 
            lblFat.AutoSize = true;
            lblFat.BackColor = Color.Transparent;
            lblFat.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFat.Location = new Point(1082, 179);
            lblFat.Name = "lblFat";
            lblFat.Size = new Size(36, 23);
            lblFat.TabIndex = 87;
            lblFat.Text = "Yağ";
            // 
            // lblCarbohydrate
            // 
            lblCarbohydrate.AutoSize = true;
            lblCarbohydrate.BackColor = Color.Transparent;
            lblCarbohydrate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarbohydrate.Location = new Point(866, 179);
            lblCarbohydrate.Name = "lblCarbohydrate";
            lblCarbohydrate.Size = new Size(112, 23);
            lblCarbohydrate.TabIndex = 86;
            lblCarbohydrate.Text = "Karbonhidrat";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.BackColor = Color.Transparent;
            lblProtein.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProtein.Location = new Point(687, 179);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(66, 23);
            lblProtein.TabIndex = 85;
            lblProtein.Text = "Protein";
            // 
            // lblCalorie2
            // 
            lblCalorie2.AutoSize = true;
            lblCalorie2.BackColor = Color.Transparent;
            lblCalorie2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalorie2.Location = new Point(349, 108);
            lblCalorie2.Name = "lblCalorie2";
            lblCalorie2.Size = new Size(40, 23);
            lblCalorie2.TabIndex = 84;
            lblCalorie2.Text = "kcal";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.BackColor = Color.Transparent;
            lblCalorie.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalorie.Location = new Point(349, 36);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(40, 23);
            lblCalorie.TabIndex = 83;
            lblCalorie.Text = "kcal";
            // 
            // lblkcal2
            // 
            lblkcal2.AutoSize = true;
            lblkcal2.BackColor = Color.Transparent;
            lblkcal2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblkcal2.Location = new Point(349, 69);
            lblkcal2.Name = "lblkcal2";
            lblkcal2.Size = new Size(40, 23);
            lblkcal2.TabIndex = 82;
            lblkcal2.Text = "kcal";
            // 
            // lblDailyTotalcal
            // 
            lblDailyTotalcal.AutoSize = true;
            lblDailyTotalcal.BackColor = Color.Transparent;
            lblDailyTotalcal.Font = new Font("Calibri", 22.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDailyTotalcal.Location = new Point(776, 49);
            lblDailyTotalcal.Name = "lblDailyTotalcal";
            lblDailyTotalcal.Size = new Size(278, 37);
            lblDailyTotalcal.TabIndex = 65;
            lblDailyTotalcal.Text = "Günlük Toplam Kalori";
            // 
            // lblWeeklyFav
            // 
            lblWeeklyFav.AutoSize = true;
            lblWeeklyFav.BackColor = Color.Transparent;
            lblWeeklyFav.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeeklyFav.Location = new Point(54, 199);
            lblWeeklyFav.Name = "lblWeeklyFav";
            lblWeeklyFav.Size = new Size(139, 23);
            lblWeeklyFav.TabIndex = 70;
            lblWeeklyFav.Text = "Haftanın Favorisi";
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.BackColor = Color.Transparent;
            lblDinner.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDinner.Location = new Point(54, 144);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(119, 23);
            lblDinner.TabIndex = 73;
            lblDinner.Text = "Akşam Yemeği";
            // 
            // lblMonthlyFav
            // 
            lblMonthlyFav.AutoSize = true;
            lblMonthlyFav.BackColor = Color.Transparent;
            lblMonthlyFav.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonthlyFav.Location = new Point(54, 233);
            lblMonthlyFav.Name = "lblMonthlyFav";
            lblMonthlyFav.Size = new Size(107, 23);
            lblMonthlyFav.TabIndex = 73;
            lblMonthlyFav.Text = "Ayın Favorisi";
            // 
            // lblLunch
            // 
            lblLunch.AutoSize = true;
            lblLunch.BackColor = Color.Transparent;
            lblLunch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLunch.Location = new Point(54, 108);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(103, 23);
            lblLunch.TabIndex = 70;
            lblLunch.Text = "Öğle Yemeği";
            // 
            // lblCalorie4
            // 
            lblCalorie4.AutoSize = true;
            lblCalorie4.BackColor = Color.Transparent;
            lblCalorie4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalorie4.Location = new Point(349, 144);
            lblCalorie4.Name = "lblCalorie4";
            lblCalorie4.Size = new Size(40, 23);
            lblCalorie4.TabIndex = 64;
            lblCalorie4.Text = "kcal";
            // 
            // lblSnack
            // 
            lblSnack.AutoSize = true;
            lblSnack.BackColor = Color.Transparent;
            lblSnack.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSnack.Location = new Point(54, 69);
            lblSnack.Name = "lblSnack";
            lblSnack.Size = new Size(83, 23);
            lblSnack.TabIndex = 67;
            lblSnack.Text = "Ara Öğün";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1313, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 98;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogOut1
            // 
            btnLogOut1.BackColor = Color.Transparent;
            btnLogOut1.BackgroundImage = (Image)resources.GetObject("btnLogOut1.BackgroundImage");
            btnLogOut1.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut1.Location = new Point(1358, 12);
            btnLogOut1.Name = "btnLogOut1";
            btnLogOut1.Size = new Size(30, 30);
            btnLogOut1.TabIndex = 99;
            btnLogOut1.UseVisualStyleBackColor = false;
            btnLogOut1.Click += btnLogOut1_Click;
            // 
            // dgv_BreakFast
            // 
            dgv_BreakFast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BreakFast.Location = new Point(224, 450);
            dgv_BreakFast.Name = "dgv_BreakFast";
            dgv_BreakFast.RowTemplate.Height = 25;
            dgv_BreakFast.Size = new Size(354, 131);
            dgv_BreakFast.TabIndex = 100;
            // 
            // dgv_Snacks
            // 
            dgv_Snacks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Snacks.Location = new Point(681, 450);
            dgv_Snacks.Name = "dgv_Snacks";
            dgv_Snacks.RowTemplate.Height = 25;
            dgv_Snacks.Size = new Size(354, 131);
            dgv_Snacks.TabIndex = 101;
            // 
            // dgv_Lunch
            // 
            dgv_Lunch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Lunch.Location = new Point(228, 637);
            dgv_Lunch.Name = "dgv_Lunch";
            dgv_Lunch.RowTemplate.Height = 25;
            dgv_Lunch.Size = new Size(354, 131);
            dgv_Lunch.TabIndex = 102;
            // 
            // dgv_Dinner
            // 
            dgv_Dinner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Dinner.Location = new Point(681, 637);
            dgv_Dinner.Name = "dgv_Dinner";
            dgv_Dinner.RowTemplate.Height = 25;
            dgv_Dinner.Size = new Size(354, 131);
            dgv_Dinner.TabIndex = 103;
            // 
            // btnRapor
            // 
            btnRapor.BackColor = Color.Transparent;
            btnRapor.Location = new Point(1136, 718);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(132, 50);
            btnRapor.TabIndex = 104;
            btnRapor.Text = "Rapor Göster";
            btnRapor.UseVisualStyleBackColor = false;
            btnRapor.Click += btnRapor_Click;
            // 
            // frmAppMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(btnRapor);
            Controls.Add(dgv_Dinner);
            Controls.Add(dgv_Lunch);
            Controls.Add(dgv_Snacks);
            Controls.Add(dgv_BreakFast);
            Controls.Add(btnLogOut1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Controls.Add(btnSnacks);
            Controls.Add(btnBreakfast);
            Controls.Add(panelforAppMainPage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAppMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAppMainPage";
            Load += frmAppMainPage_Load;
            panelforAppMainPage.ResumeLayout(false);
            panelforAppMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_BreakFast).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Snacks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Lunch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Dinner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDinner;
        private Button btnLunch;
        private Button btnSnacks;
        private Button btnBreakfast;
        private Label lblBreakfast;
        private Panel panelforAppMainPage;
        private Label lblAyFavori;
        private Label lblHaftaFavori;
        private Label lblAksam;
        private Label lblÖğle;
        private Label lblAraÖğün;
        private Label lblKahvaltı;
        private Label lblFat;
        private Label lblCarbohydrate;
        private Label lblProtein;
        private Label lblCalorie2;
        private Label lblCalorie;
        private Label lblkcal2;
        private Label lblDailyTotalcal;
        private Label lblWeeklyFav;
        private Label lblDinner;
        private Label lblMonthlyFav;
        private Label lblLunch;
        private Label lblCalorie4;
        private Label lblSnack;
        private PictureBox pictureBox1;
        private Button btnLogOut1;
        private Label lblYağ;
        private Label lblCarbon;
        private Label lblPro;
        private Label label9;
        private Label lblTotalCal;
        private Label lblTakenCal;
        private DataGridView dgv_BreakFast;
        private DataGridView dgv_Snacks;
        private DataGridView dgv_Lunch;
        private DataGridView dgv_Dinner;
        private Button btnRapor;
    }
}