namespace DietProgram.UI.AppUI
{
    partial class frmBreakfastPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBreakfastPage));
            btnBack = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lblBreakfast = new Label();
            lblPortions = new Label();
            numericUdPortions = new NumericUpDown();
            dgvBreakfast = new DataGridView();
            lblSearch = new Label();
            textBox6 = new TextBox();
            btnDrinks = new Button();
            btnBakeryProducts = new Button();
            btnNutriens = new Button();
            btnFood = new Button();
            btnNutritionalSupplements = new Button();
            btnFruitVegatable = new Button();
            btnDelicatessen = new Button();
            btnforBreakfast = new Button();
            btnSnacks = new Button();
            btnAll = new Button();
            btnLogOut4 = new Button();
            dgvBreak = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUdPortions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakfast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreak).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 740);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 48);
            btnBack.TabIndex = 49;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1253, 694);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 33);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(658, 503);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 33);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.BackColor = Color.Transparent;
            lblBreakfast.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBreakfast.Location = new Point(873, 320);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(73, 23);
            lblBreakfast.TabIndex = 46;
            lblBreakfast.Text = "Kahvaltı";
            // 
            // lblPortions
            // 
            lblPortions.AutoSize = true;
            lblPortions.BackColor = Color.Transparent;
            lblPortions.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPortions.Location = new Point(726, 389);
            lblPortions.Name = "lblPortions";
            lblPortions.Size = new Size(130, 23);
            lblPortions.TabIndex = 45;
            lblPortions.Text = "Porsiyon Adedi";
            // 
            // numericUdPortions
            // 
            numericUdPortions.Location = new Point(726, 358);
            numericUdPortions.Margin = new Padding(3, 4, 3, 4);
            numericUdPortions.Name = "numericUdPortions";
            numericUdPortions.Size = new Size(130, 23);
            numericUdPortions.TabIndex = 44;
            numericUdPortions.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvBreakfast
            // 
            dgvBreakfast.BackgroundColor = SystemColors.Info;
            dgvBreakfast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakfast.Location = new Point(64, 358);
            dgvBreakfast.Name = "dgvBreakfast";
            dgvBreakfast.RowTemplate.Height = 25;
            dgvBreakfast.Size = new Size(491, 331);
            dgvBreakfast.TabIndex = 42;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(64, 311);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 23);
            lblSearch.TabIndex = 41;
            lblSearch.Text = "Ara :";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(126, 307);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(429, 23);
            textBox6.TabIndex = 40;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = SystemColors.Control;
            btnDrinks.BackgroundImage = (Image)resources.GetObject("btnDrinks.BackgroundImage");
            btnDrinks.BackgroundImageLayout = ImageLayout.Stretch;
            btnDrinks.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrinks.ForeColor = Color.White;
            btnDrinks.Location = new Point(950, 199);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(169, 58);
            btnDrinks.TabIndex = 39;
            btnDrinks.Text = "İçecek";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // btnBakeryProducts
            // 
            btnBakeryProducts.BackColor = SystemColors.Control;
            btnBakeryProducts.BackgroundImage = (Image)resources.GetObject("btnBakeryProducts.BackgroundImage");
            btnBakeryProducts.BackgroundImageLayout = ImageLayout.Stretch;
            btnBakeryProducts.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBakeryProducts.ForeColor = Color.White;
            btnBakeryProducts.Location = new Point(728, 199);
            btnBakeryProducts.Name = "btnBakeryProducts";
            btnBakeryProducts.Size = new Size(169, 58);
            btnBakeryProducts.TabIndex = 38;
            btnBakeryProducts.Text = "Unlu Mamuller";
            btnBakeryProducts.UseVisualStyleBackColor = false;
            btnBakeryProducts.Click += btnBakeryProducts_Click;
            // 
            // btnNutriens
            // 
            btnNutriens.BackColor = SystemColors.Control;
            btnNutriens.BackgroundImage = (Image)resources.GetObject("btnNutriens.BackgroundImage");
            btnNutriens.BackgroundImageLayout = ImageLayout.Stretch;
            btnNutriens.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNutriens.ForeColor = Color.White;
            btnNutriens.Location = new Point(518, 199);
            btnNutriens.Name = "btnNutriens";
            btnNutriens.Size = new Size(169, 58);
            btnNutriens.TabIndex = 37;
            btnNutriens.Text = "Gıda";
            btnNutriens.UseVisualStyleBackColor = false;
            btnNutriens.Click += btnNutriens_Click;
            // 
            // btnFood
            // 
            btnFood.BackColor = SystemColors.Control;
            btnFood.BackgroundImage = (Image)resources.GetObject("btnFood.BackgroundImage");
            btnFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnFood.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFood.ForeColor = Color.White;
            btnFood.Location = new Point(311, 199);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(169, 58);
            btnFood.TabIndex = 36;
            btnFood.Text = "Yemek";
            btnFood.UseVisualStyleBackColor = false;
            btnFood.Click += btnFood_Click;
            // 
            // btnNutritionalSupplements
            // 
            btnNutritionalSupplements.BackColor = SystemColors.Control;
            btnNutritionalSupplements.BackgroundImage = (Image)resources.GetObject("btnNutritionalSupplements.BackgroundImage");
            btnNutritionalSupplements.BackgroundImageLayout = ImageLayout.Stretch;
            btnNutritionalSupplements.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNutritionalSupplements.ForeColor = Color.White;
            btnNutritionalSupplements.Location = new Point(1162, 125);
            btnNutritionalSupplements.Name = "btnNutritionalSupplements";
            btnNutritionalSupplements.Size = new Size(169, 58);
            btnNutritionalSupplements.TabIndex = 35;
            btnNutritionalSupplements.Text = "Besin Takviyeleri";
            btnNutritionalSupplements.UseVisualStyleBackColor = false;
            btnNutritionalSupplements.Click += btnNutritionalSupplements_Click;
            // 
            // btnFruitVegatable
            // 
            btnFruitVegatable.BackColor = SystemColors.Control;
            btnFruitVegatable.BackgroundImage = (Image)resources.GetObject("btnFruitVegatable.BackgroundImage");
            btnFruitVegatable.BackgroundImageLayout = ImageLayout.Stretch;
            btnFruitVegatable.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFruitVegatable.ForeColor = Color.White;
            btnFruitVegatable.Location = new Point(950, 125);
            btnFruitVegatable.Name = "btnFruitVegatable";
            btnFruitVegatable.Size = new Size(169, 58);
            btnFruitVegatable.TabIndex = 34;
            btnFruitVegatable.Text = "Meyve Sebze";
            btnFruitVegatable.UseVisualStyleBackColor = false;
            btnFruitVegatable.Click += btnFruitVegatable_Click;
            // 
            // btnDelicatessen
            // 
            btnDelicatessen.BackColor = SystemColors.Control;
            btnDelicatessen.BackgroundImage = (Image)resources.GetObject("btnDelicatessen.BackgroundImage");
            btnDelicatessen.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelicatessen.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelicatessen.ForeColor = Color.White;
            btnDelicatessen.Location = new Point(728, 125);
            btnDelicatessen.Name = "btnDelicatessen";
            btnDelicatessen.Size = new Size(169, 58);
            btnDelicatessen.TabIndex = 33;
            btnDelicatessen.Text = "Et,Tavuk,Balık";
            btnDelicatessen.UseVisualStyleBackColor = false;
            btnDelicatessen.Click += btnDelicatessen_Click;
            // 
            // btnforBreakfast
            // 
            btnforBreakfast.BackColor = SystemColors.Control;
            btnforBreakfast.BackgroundImage = (Image)resources.GetObject("btnforBreakfast.BackgroundImage");
            btnforBreakfast.BackgroundImageLayout = ImageLayout.Stretch;
            btnforBreakfast.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnforBreakfast.ForeColor = Color.White;
            btnforBreakfast.Location = new Point(518, 125);
            btnforBreakfast.Name = "btnforBreakfast";
            btnforBreakfast.Size = new Size(169, 58);
            btnforBreakfast.TabIndex = 32;
            btnforBreakfast.Text = "Kahvaltılık";
            btnforBreakfast.UseVisualStyleBackColor = false;
            btnforBreakfast.Click += btnforBreakfast_Click;
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = SystemColors.Control;
            btnSnacks.BackgroundImage = (Image)resources.GetObject("btnSnacks.BackgroundImage");
            btnSnacks.BackgroundImageLayout = ImageLayout.Stretch;
            btnSnacks.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSnacks.ForeColor = Color.White;
            btnSnacks.Location = new Point(311, 125);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(169, 58);
            btnSnacks.TabIndex = 31;
            btnSnacks.Text = "Atıştırmalıklar";
            btnSnacks.UseVisualStyleBackColor = false;
            btnSnacks.Click += btnSnacks_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Control;
            btnAll.BackgroundImage = (Image)resources.GetObject("btnAll.BackgroundImage");
            btnAll.BackgroundImageLayout = ImageLayout.Stretch;
            btnAll.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(101, 125);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(169, 58);
            btnAll.TabIndex = 30;
            btnAll.Text = "Tümü";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnLogOut4
            // 
            btnLogOut4.BackColor = Color.Transparent;
            btnLogOut4.BackgroundImage = (Image)resources.GetObject("btnLogOut4.BackgroundImage");
            btnLogOut4.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut4.Location = new Point(1358, 12);
            btnLogOut4.Name = "btnLogOut4";
            btnLogOut4.Size = new Size(30, 30);
            btnLogOut4.TabIndex = 50;
            btnLogOut4.UseVisualStyleBackColor = false;
            btnLogOut4.Click += btnLogOut4_Click;
            // 
            // dgvBreak
            // 
            dgvBreak.BackgroundColor = SystemColors.Info;
            dgvBreak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreak.Location = new Point(870, 358);
            dgvBreak.Name = "dgvBreak";
            dgvBreak.RowTemplate.Height = 25;
            dgvBreak.Size = new Size(518, 330);
            dgvBreak.TabIndex = 51;
            // 
            // frmBreakfastPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(dgvBreak);
            Controls.Add(btnLogOut4);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblBreakfast);
            Controls.Add(lblPortions);
            Controls.Add(numericUdPortions);
            Controls.Add(dgvBreakfast);
            Controls.Add(lblSearch);
            Controls.Add(textBox6);
            Controls.Add(btnDrinks);
            Controls.Add(btnBakeryProducts);
            Controls.Add(btnNutriens);
            Controls.Add(btnFood);
            Controls.Add(btnNutritionalSupplements);
            Controls.Add(btnFruitVegatable);
            Controls.Add(btnDelicatessen);
            Controls.Add(btnforBreakfast);
            Controls.Add(btnSnacks);
            Controls.Add(btnAll);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBreakfastPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBreakfastPage";
            Load += frmBreakfastPage_Load;
            ((System.ComponentModel.ISupportInitialize)numericUdPortions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakfast).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblBreakfast;
        private Label lblPortions;
        private NumericUpDown numericUdPortions;
        private DataGridView dgvBreakfast;
        private Label lblSearch;
        private TextBox textBox6;
        private Button btnDrinks;
        private Button btnBakeryProducts;
        private Button btnNutriens;
        private Button btnFood;
        private Button btnNutritionalSupplements;
        private Button btnFruitVegatable;
        private Button btnDelicatessen;
        private Button btnforBreakfast;
        private Button btnSnacks;
        private Button btnAll;
        private Button btnLogOut4;
        private DataGridView dgvBreak;
    }
}