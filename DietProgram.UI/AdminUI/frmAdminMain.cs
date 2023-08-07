using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Entities;
using DietProgram.Models.VMs.CategoryVM;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.UI.AppUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProgram.UI.AdminUI
{
    public partial class frmAdminMain : Form
    {
        private readonly IFoodService _foodService;
        DietProgramDbContext _db;
        public frmAdminMain( IFoodService foodService)
        {
            InitializeComponent();
            _foodService = foodService;
            _db = new DietProgramDbContext();


        }

        private void btnLogOut2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainPage frmMainPage = (frmMainPage)EFContextForm.EFContextForm.ConfigureService<frmMainPage>();
            this.Hide();
            frmMainPage.ShowDialog();
            this.Close();
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            var categories = _db.Categories.Select(x => x.CategoryName).ToList(); // Combobox içine kategorileri getirmek için
            cbProductCategory.DataSource = categories.ToList();

            var foods = _db.Foods.Select(x => new
            {
                x.Id,
                x.FoodName,
                x.Kcal,
                x.Protein,
                x.Carbonhydrate,
                x.Fat,
                x.Picture
            });
            dgvProduct.DataSource = foods.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pbProductPicture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);


            FoodCreateVM foodCreateVM = new FoodCreateVM()
            {

                FoodName = txtProductName.Text,
                Carbonhydrate = Convert.ToInt32(txtCarbohydrateValue.Text),
                Kcal = Convert.ToInt32(txtProductCalorie.Text),
                Fat = Convert.ToInt32(txtFatValue.Text),
                Protein = Convert.ToInt32(txtProteinValue.Text),
                CategoryID = _db.Categories.Where(x => x.CategoryName == cbProductCategory.Text)
                                                              .Select(x => x.Id).FirstOrDefault(),
                Picture = stream.ToArray()

            };
            var data = _foodService.Create(foodCreateVM);
            if (data.HasError)
            {
                MessageBox.Show("Kayıt başarısız");

            }
            else
            {
                MessageBox.Show("Kayıt başarılı");

                frmAdminMain frm = (frmAdminMain)EFContextForm.EFContextForm.ConfigureService<frmAdminMain>();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = "jpg";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.ShowDialog();
                string path = openFileDialog.FileName;
                pbProductPicture.Image = Image.FromFile(path);
                pbProductPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                throw new Exception("Lütfen bir resim seçiniz");
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsLetter(e);

        }

        private static void IsLetter(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Sadece Harf giriniz!");
            }
        }

        private void txtProductCalorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private static void IsDigit(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Sadece sayı giriniz!");
            }
        }

        private void txtProteinValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtCarbohydrateValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtFatValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var foods = _db.Foods.Where(x => x.FoodName == txtSearch.Text).Select(x => new
            {
                x.Id,
                x.FoodName,
                x.Kcal,
                x.Protein,
                x.Carbonhydrate,
                x.Fat,
                x.Picture
            });

            var newData = _foodService.FindFoodByName(txtSearch.Text);
            if (newData.HasError)
            {
                MessageBox.Show("Yemek bulunamadı");
            }
            else
            {
                dgvProduct.DataSource = foods.ToList();
                if (txtSearch.Text.Length == 0)
                {
                    dgvProduct.DataSource = _foodService.GetAll().Data.ToList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = (int)dgvProduct.SelectedCells[0].Value;
            _foodService.Delete(id);
            MessageBox.Show("Başarıyla silindi.");
            frmAdminMain frm = (frmAdminMain)EFContextForm.EFContextForm.ConfigureService<frmAdminMain>();
            frm.Show();
            dgvProduct.DataSource = _foodService.GetAll().Data.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pbProductPicture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            string foodName = dgvProduct.SelectedRows[0].Cells["FoodName"].Value.ToString();
            FoodUpdateVM updateVm = new FoodUpdateVM()
            {
                Id = _db.Foods.FirstOrDefault(x => x.FoodName == foodName).Id,
                FoodName = txtProductName.Text,
                Carbonhydrate = Convert.ToInt32(txtCarbohydrateValue.Text),
                Kcal = Convert.ToInt32(txtProductCalorie.Text),
                Fat = Convert.ToInt32(txtFatValue.Text),
                Protein = Convert.ToInt32(txtProteinValue.Text),
                CategoryId = _db.Categories.FirstOrDefault(x => x.CategoryName == cbProductCategory.Text).Id,
                Picture = stream.ToArray()

            };
            _foodService.Update(updateVm);
            MessageBox.Show("Başarıyla güncellendi.");
            dgvProduct.DataSource = _foodService.GetAll().Data.ToList();
        }
    }
}
