namespace DietProgram.UI.AdminUI
{
    partial class frmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            lblSearch = new Label();
            lblProductPicture = new Label();
            lblFatValue = new Label();
            lblCarbohydrateValue = new Label();
            lblProteinValue = new Label();
            lblProductCalorie = new Label();
            lblProductCategory = new Label();
            lblProductName = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            pbProductPicture = new PictureBox();
            txtSearch = new TextBox();
            txtFatValue = new TextBox();
            txtCarbohydrateValue = new TextBox();
            txtProteinValue = new TextBox();
            txtProductCalorie = new TextBox();
            txtProductName = new TextBox();
            btnExit = new Button();
            cbProductCategory = new ComboBox();
            dgvProduct = new DataGridView();
            btnLogOut2 = new Button();
            btnAddPicture = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(821, 131);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 23);
            lblSearch.TabIndex = 41;
            lblSearch.Text = "Ara :";
            // 
            // lblProductPicture
            // 
            lblProductPicture.AutoSize = true;
            lblProductPicture.BackColor = Color.Transparent;
            lblProductPicture.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductPicture.Location = new Point(110, 520);
            lblProductPicture.Name = "lblProductPicture";
            lblProductPicture.Size = new Size(125, 23);
            lblProductPicture.TabIndex = 40;
            lblProductPicture.Text = "Ürün Fotoğrafı";
            // 
            // lblFatValue
            // 
            lblFatValue.AutoSize = true;
            lblFatValue.BackColor = Color.Transparent;
            lblFatValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFatValue.Location = new Point(110, 456);
            lblFatValue.Name = "lblFatValue";
            lblFatValue.Size = new Size(103, 23);
            lblFatValue.TabIndex = 39;
            lblFatValue.Text = "Yağ Değeri :";
            // 
            // lblCarbohydrateValue
            // 
            lblCarbohydrateValue.AutoSize = true;
            lblCarbohydrateValue.BackColor = Color.Transparent;
            lblCarbohydrateValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarbohydrateValue.Location = new Point(110, 392);
            lblCarbohydrateValue.Name = "lblCarbohydrateValue";
            lblCarbohydrateValue.Size = new Size(180, 23);
            lblCarbohydrateValue.TabIndex = 38;
            lblCarbohydrateValue.Text = "Karbonhidrat Değeri :";
            // 
            // lblProteinValue
            // 
            lblProteinValue.AutoSize = true;
            lblProteinValue.BackColor = Color.Transparent;
            lblProteinValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProteinValue.Location = new Point(110, 331);
            lblProteinValue.Name = "lblProteinValue";
            lblProteinValue.Size = new Size(135, 23);
            lblProteinValue.TabIndex = 37;
            lblProteinValue.Text = "Protein Değeri :";
            // 
            // lblProductCalorie
            // 
            lblProductCalorie.AutoSize = true;
            lblProductCalorie.BackColor = Color.Transparent;
            lblProductCalorie.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCalorie.Location = new Point(110, 271);
            lblProductCalorie.Name = "lblProductCalorie";
            lblProductCalorie.Size = new Size(121, 23);
            lblProductCalorie.TabIndex = 36;
            lblProductCalorie.Text = "Ürün Kalorisi :";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.BackColor = Color.Transparent;
            lblProductCategory.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCategory.Location = new Point(110, 134);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(142, 23);
            lblProductCategory.TabIndex = 35;
            lblProductCategory.Text = "Ürün Kategorisi :";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(110, 202);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(89, 23);
            lblProductName.TabIndex = 34;
            lblProductName.Text = "Ürün Adı :";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(414, 646);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 33);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(414, 595);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 33);
            btnDelete.TabIndex = 33;
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
            btnAdd.Location = new Point(414, 546);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 33);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pbProductPicture
            // 
            pbProductPicture.BorderStyle = BorderStyle.Fixed3D;
            pbProductPicture.Location = new Point(110, 546);
            pbProductPicture.Name = "pbProductPicture";
            pbProductPicture.Size = new Size(274, 133);
            pbProductPicture.TabIndex = 30;
            pbProductPicture.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(883, 134);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(429, 23);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtFatValue
            // 
            txtFatValue.BackColor = SystemColors.ScrollBar;
            txtFatValue.Location = new Point(110, 482);
            txtFatValue.Name = "txtFatValue";
            txtFatValue.Size = new Size(441, 23);
            txtFatValue.TabIndex = 28;
            txtFatValue.KeyPress += txtFatValue_KeyPress;
            // 
            // txtCarbohydrateValue
            // 
            txtCarbohydrateValue.BackColor = SystemColors.ScrollBar;
            txtCarbohydrateValue.Location = new Point(110, 418);
            txtCarbohydrateValue.Name = "txtCarbohydrateValue";
            txtCarbohydrateValue.Size = new Size(441, 23);
            txtCarbohydrateValue.TabIndex = 27;
            txtCarbohydrateValue.KeyPress += txtCarbohydrateValue_KeyPress;
            // 
            // txtProteinValue
            // 
            txtProteinValue.BackColor = SystemColors.ScrollBar;
            txtProteinValue.Location = new Point(110, 357);
            txtProteinValue.Name = "txtProteinValue";
            txtProteinValue.Size = new Size(441, 23);
            txtProteinValue.TabIndex = 26;
            txtProteinValue.KeyPress += txtProteinValue_KeyPress;
            // 
            // txtProductCalorie
            // 
            txtProductCalorie.BackColor = SystemColors.ScrollBar;
            txtProductCalorie.Location = new Point(110, 297);
            txtProductCalorie.Name = "txtProductCalorie";
            txtProductCalorie.Size = new Size(441, 23);
            txtProductCalorie.TabIndex = 25;
            txtProductCalorie.KeyPress += txtProductCalorie_KeyPress;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.ScrollBar;
            txtProductName.Location = new Point(110, 228);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(441, 23);
            txtProductName.TabIndex = 24;
            txtProductName.KeyPress += txtProductName_KeyPress;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(1249, 740);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 48);
            btnExit.TabIndex = 23;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = SystemColors.ScrollBar;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Location = new Point(110, 160);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(441, 23);
            cbProductCategory.TabIndex = 22;
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = SystemColors.Info;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(598, 160);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 90;
            dgvProduct.Size = new Size(761, 468);
            dgvProduct.TabIndex = 21;
            // 
            // btnLogOut2
            // 
            btnLogOut2.BackColor = Color.Transparent;
            btnLogOut2.BackgroundImage = (Image)resources.GetObject("btnLogOut2.BackgroundImage");
            btnLogOut2.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut2.Location = new Point(1358, 12);
            btnLogOut2.Name = "btnLogOut2";
            btnLogOut2.Size = new Size(30, 30);
            btnLogOut2.TabIndex = 42;
            btnLogOut2.UseVisualStyleBackColor = false;
            btnLogOut2.Click += btnLogOut2_Click;
            // 
            // btnAddPicture
            // 
            btnAddPicture.BackColor = SystemColors.Control;
            btnAddPicture.BackgroundImage = (Image)resources.GetObject("btnAddPicture.BackgroundImage");
            btnAddPicture.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPicture.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPicture.ForeColor = Color.White;
            btnAddPicture.Location = new Point(110, 696);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(137, 33);
            btnAddPicture.TabIndex = 43;
            btnAddPicture.Text = "Fotoğraf Ekle";
            btnAddPicture.UseVisualStyleBackColor = false;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // frmAdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(btnAddPicture);
            Controls.Add(btnLogOut2);
            Controls.Add(lblSearch);
            Controls.Add(lblProductPicture);
            Controls.Add(lblFatValue);
            Controls.Add(lblCarbohydrateValue);
            Controls.Add(lblProteinValue);
            Controls.Add(lblProductCalorie);
            Controls.Add(lblProductCategory);
            Controls.Add(lblProductName);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(pbProductPicture);
            Controls.Add(txtSearch);
            Controls.Add(txtFatValue);
            Controls.Add(txtCarbohydrateValue);
            Controls.Add(txtProteinValue);
            Controls.Add(txtProductCalorie);
            Controls.Add(txtProductName);
            Controls.Add(btnExit);
            Controls.Add(cbProductCategory);
            Controls.Add(dgvProduct);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminMain";
            Load += frmAdminMain_Load;
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private Label lblProductPicture;
        private Label lblFatValue;
        private Label lblCarbohydrateValue;
        private Label lblProteinValue;
        private Label lblProductCalorie;
        private Label lblProductCategory;
        private Label lblProductName;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private PictureBox pbProductPicture;
        private TextBox txtSearch;
        private TextBox txtFatValue;
        private TextBox txtCarbohydrateValue;
        private TextBox txtProteinValue;
        private TextBox txtProductCalorie;
        private TextBox txtProductName;
        private Button btnExit;
        private ComboBox cbProductCategory;
        private DataGridView dgvProduct;
        private Button btnLogOut2;
        private Button btnAddPicture;
    }
}