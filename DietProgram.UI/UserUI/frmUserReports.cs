using DietProgram.BLL.Abstract.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProgram.UI.UserUI
{
    public partial class frmUserReports : Form
    {
        private readonly IUserFoodInfoService _foodInfoService;
        public int id { get; set; }
        public frmUserReports(IUserFoodInfoService foodInfoService)
        {
            InitializeComponent();
            _foodInfoService = foodInfoService;
        }

        private void frmUserReports_Load(object sender, EventArgs e)
        {

            //var userInfos = _foodInfoService.GetWeeklyTopFood().Data.ToList();
            //var data = userInfos.Where(x => x.UserID == id).Select(x => new
            //{
            //    x.FoodName,
            //    x.Kcal,
            //    x.Portion,
            //    x.MealName,
            //    x.EatDate,
            //    x.TakenCalorie,
            //    x.Protein,
            //    x.Carbonhydrate,
            //    x.Fat
            //});
            //dgvHaftalık.DataSource = data.ToList();
            //dgvHaftalık.Refresh();
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
            var userInfosMonthly = _foodInfoService.GetMonthlyTopFood().Data.ToList();
            var monthlyData = userInfosMonthly.Where(x => x.UserID == id).Select(x => new
            {
                x.FoodName,
                x.Kcal,
                x.Portion,
                x.MealName,
                x.EatDate,
                x.TakenCalorie,
                x.Protein,
                x.Carbonhydrate,
                x.Fat
            });
            dgvMonthly.DataSource = monthlyData.ToList();

            var userInfos = _foodInfoService.GetWeeklyTopFood().Data.ToList();
            var weeklyData = userInfos.Where(x => x.UserID == id).Select(x => new
            {

                x.FoodName,
                x.Kcal,
                x.Portion,
                x.MealName,
                x.EatDate,
                x.TakenCalorie,
                x.Protein,
                x.Carbonhydrate,
                x.Fat
            });
            dgvWeekly.DataSource = weeklyData.ToList();


        }
        
    }
}
