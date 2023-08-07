using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Models.VMs.UserFoodInfoVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietProgram.UI.AppUI
{
    public partial class frmSnacks : Form
    {
        private readonly IUserFoodInfoService _foodInfoService;
        private readonly IFoodService _foodService;
        DietProgramDbContext _context;
        public int id { get; set; }
        public frmSnacks(IFoodService foodService, IUserFoodInfoService foodInfoService)
        {
            InitializeComponent();
            _context = new DietProgramDbContext();
            _foodService = foodService;
            _foodInfoService = foodInfoService;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            //frmAppMainPage frm = (frmAppMainPage)EFContextForm.EFContextForm.ConfigureService<frmAppMainPage>();
            //frm.ShowDialog();
            //this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {

            var foods = _context.Foods.Select(x => new
            {
                
                x.FoodName,
                x.Kcal,
                x.Protein,
                x.Carbonhydrate,
                x.Fat

            });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = this.id;
            string foodName = dgvSnack.SelectedRows[0].Cells["FoodName"].Value.ToString();
            double kcal = Convert.ToInt32(dgvSnack.SelectedRows[0].Cells["Kcal"].Value);
            double protein = Convert.ToInt32(dgvSnack.SelectedRows[0].Cells["Protein"].Value);
            double carbonhydrate = Convert.ToInt32(dgvSnack.SelectedRows[0].Cells["Carbonhydrate"].Value);
            double fat = Convert.ToInt32(dgvSnack.SelectedRows[0].Cells["Fat"].Value);
            int portion = (int)numericUpDownPortions.Value;
            int takenCalorie = (int)kcal * portion;

            UserFoodInfoCreateVm userFoodInfoCreateVm = new UserFoodInfoCreateVm()
            {
                UserID=id,
                FoodName = foodName,
                Kcal = kcal,
                Protein = protein * portion,
                Carbonhydrate = carbonhydrate*portion,
                Fat = fat*portion,
                EatDate = DateTime.Now,
                MealName = lblSnacks.Text,
                Portion = portion,
                TakenCalorie = takenCalorie,

            };

            _foodInfoService.Create(userFoodInfoCreateVm);
            MessageBox.Show("Öğüne Başarıyla Eklendi");
            string mealName = lblSnacks.Text;
            dgvSelectedFood.DataSource = _foodInfoService.GetAll(mealName, id).Data.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.FoodName == txtSearch.Text).Select(x => new
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
                dgvSnack.DataSource = foods.ToList();
                if (txtSearch.Text.Length == 0)
                {



                    dgvSnack.DataSource = _foodService.GetAll().Data.ToList();
                }
            }
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 2)
                .Select(x => new
                {
                    x.FoodName,
                    x.Kcal,
                    x.Protein,
                    x.Carbonhydrate,
                    x.Fat

                });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnforBreakfast_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 3)
                .Select(x => new
                {
                    x.FoodName,
                    x.Kcal,
                    x.Protein,
                    x.Carbonhydrate,
                    x.Fat

                });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnDelicatessen_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 4)
               .Select(x => new
               {
                   x.FoodName,
                   x.Kcal,
                   x.Protein,
                   x.Carbonhydrate,
                   x.Fat

               });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnFruitVegatable_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 5)
                .Select(x => new
                {
                    x.FoodName,
                    x.Kcal,
                    x.Protein,
                    x.Carbonhydrate,
                    x.Fat

                });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnNutritionalSupplements_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 6)
               .Select(x => new
               {
                   x.FoodName,
                   x.Kcal,
                   x.Protein,
                   x.Carbonhydrate,
                   x.Fat

               });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 7)
               .Select(x => new
               {
                   x.FoodName,
                   x.Kcal,
                   x.Protein,
                   x.Carbonhydrate,
                   x.Fat

               });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnNutriens_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 8)
                .Select(x => new
                {
                    x.FoodName,
                    x.Kcal,
                    x.Protein,
                    x.Carbonhydrate,
                    x.Fat

                });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnBakeryProducts_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 9)
                .Select(x => new
                {
                    x.FoodName,
                    x.Kcal,
                    x.Protein,
                    x.Carbonhydrate,
                    x.Fat

                });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            var foods = _context.Foods.Where(x => x.CategoryId == 10)
                .Select(x => new
                {
                    x.FoodName,
                    x.Kcal,
                    x.Protein,
                    x.Carbonhydrate,
                    x.Fat

                });
            dgvSnack.DataSource = foods.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string foodNames = dgvSelectedFood.SelectedRows[0].Cells["FoodName"].Value.ToString();

            int id = _context.UserFoodInfos.FirstOrDefault(x => x.FoodName == foodNames).Id;

            _foodInfoService.Delete(id);
            MessageBox.Show("Başarıyla silindi");
            string mealName = lblSnacks.Text;
            dgvSelectedFood.DataSource = _foodInfoService.GetAll(mealName, id).Data.ToList();
        }
    }
}
