using DietProgram.BLL.Abstract.IServices;
using DietProgram.BLL.Concrete.Services;
using DietProgram.DAL.Concrete.Context;
using DietProgram.UI.UserUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProgram.UI.AppUI
{
    public partial class frmAppMainPage : Form
    {
        public int id { get; set; }
        private readonly IUserFoodInfoService _foodInfoService;


        DietProgramDbContext _dbContext;

        public frmAppMainPage(IUserFoodInfoService foodInfoService)
        {
            InitializeComponent();
            _dbContext = new DietProgramDbContext();
            _foodInfoService = foodInfoService;
        }

        /// <summary>
        /// This method is created to display the data in the user information table in the relevant texts.
        /// </summary>
        private void DisplayOnScreen()
        {
            int id = this.id;
            var TotalCal = _dbContext.UserInfos.Where(x => x.UserId == id).Select(x => x.TotalCalorie).FirstOrDefault();
            lblTotalCal.Text = TotalCal.ToString();
            string mealNameBreakFast = btnBreakfast.Text;
            string mealNameLunch = btnLunch.Text;
            string mealNameDinner = btnDinner.Text;
            string mealNameSnack = btnSnacks.Text;
            dgv_BreakFast.DataSource = _foodInfoService.GetAll(mealNameBreakFast,id).Data.ToList();  /////// It lists the foods eaten that day on the 
            dgv_Dinner.DataSource = _foodInfoService.GetAll(mealNameDinner,id).Data.ToList();         /// datagridviews of the meals.
            dgv_Lunch.DataSource = _foodInfoService.GetAll(mealNameLunch, id).Data.ToList();
            dgv_Snacks.DataSource = _foodInfoService.GetAll(mealNameSnack,id).Data.ToList();


            var breakfastCalories = _foodInfoService.GetAll(mealNameBreakFast, id).Data.ToList();   //// It lists the total calories in the label for 
            var calorieBreakFast = string.Join(", ", breakfastCalories.Sum(x => x.TakenCalorie));       //breakfast.


            var dinnerCalories = _foodInfoService.GetAll(mealNameDinner,id).Data.ToList();         //// It lists the total calories in the label for 
            var calorieDinner = string.Join(", ", dinnerCalories.Sum(x => x.TakenCalorie));      /// dinner


            var lunchCalories = _foodInfoService.GetAll(mealNameLunch,id).Data.ToList();           //// It lists the total calories in the label for 
            var calorieLunch = string.Join(", ", lunchCalories.Sum(x => x.TakenCalorie));       //lunch


            var snackCalories = _foodInfoService.GetAll(mealNameSnack,id).Data.ToList();       //// It lists the total calories in the label for 
            var calorieSnack = string.Join(", ", snackCalories.Sum(x => x.TakenCalorie));   /// snack
            ;

            int breakfastTotalKcal = Convert.ToInt32(calorieBreakFast);
            int dinnerTotalKcal = Convert.ToInt32(calorieDinner);
            int lunchTotalKcal = Convert.ToInt32(calorieLunch);
            int snackTotalKcal = Convert.ToInt32(calorieSnack);
            lblKahvaltı.Text = breakfastTotalKcal.ToString();
            lblAksam.Text = dinnerTotalKcal.ToString();
            lblÖğle.Text = lunchTotalKcal.ToString();
            lblAraÖğün.Text = snackTotalKcal.ToString();



            int sum = breakfastTotalKcal + dinnerTotalKcal + lunchTotalKcal + snackTotalKcal;
            lblTakenCal.Text = sum.ToString();

            TakenTotalFat(mealNameBreakFast, mealNameLunch, mealNameDinner, mealNameSnack);
            TakenTotalCarbon(mealNameBreakFast, mealNameLunch, mealNameDinner, mealNameSnack);
            TakenTotalProtein(mealNameBreakFast, mealNameLunch, mealNameDinner, mealNameSnack);





        }


        private void TakenTotalProtein(string mealNameBreakFast, string mealNameLunch, string mealNameDinner, string mealNameSnack)
        {
            int id = this.id;
            var breakfastProtein = _foodInfoService.GetAll(mealNameBreakFast, id).Data.ToList();
            var proteinBreakfast = string.Join(", ", breakfastProtein.Sum(x => x.Protein));


            var dinnerProtein = _foodInfoService.GetAll(mealNameDinner,id).Data.ToList();
            var proteinDinner = string.Join(", ", dinnerProtein.Sum(x => x.Protein));


            var lunchProtein = _foodInfoService.GetAll(mealNameLunch, id).Data.ToList();
            var proteinLunch = string.Join(", ", lunchProtein.Sum(x => x.Protein));


            var snackProtein = _foodInfoService.GetAll(mealNameSnack, id).Data.ToList();
            var proteinSnack = string.Join(", ", snackProtein.Sum(x => x.Protein));


            int breakfastTotalProtein = Convert.ToInt32(proteinBreakfast);
            int dinnerTotalProtein = Convert.ToInt32(proteinDinner);
            int lunchTotalProtein = Convert.ToInt32(proteinLunch);
            int snackTotalProtein = Convert.ToInt32(proteinSnack);
            int sumProtein = breakfastTotalProtein + dinnerTotalProtein + lunchTotalProtein + snackTotalProtein;
            lblPro.Text = sumProtein.ToString();
        }


        private void TakenTotalCarbon(string mealNameBreakFast, string mealNameLunch, string mealNameDinner, string mealNameSnack)
        {
            int id = this.id;
            var breakfastCarbon = _foodInfoService.GetAll(mealNameBreakFast, id).Data.ToList();
            var carbonBreakfast = string.Join(", ", breakfastCarbon.Sum(x => x.Carbonhydrate));


            var dinnerCarbon = _foodInfoService.GetAll(mealNameDinner, id).Data.ToList();
            var carbonDinner = string.Join(", ", dinnerCarbon.Sum(x => x.Carbonhydrate));


            var lunchCarbon = _foodInfoService.GetAll(mealNameLunch, id).Data.ToList();
            var carbonLunch = string.Join(", ", lunchCarbon.Sum(x => x.Carbonhydrate));


            var snackCarbon = _foodInfoService.GetAll(mealNameSnack, id).Data.ToList();
            var carbonSnack = string.Join(", ", snackCarbon.Sum(x => x.Carbonhydrate));


            int breakfastTotalCarbon = Convert.ToInt32(carbonBreakfast);
            int dinnerTotalCarbon = Convert.ToInt32(carbonDinner);
            int lunchTotalCarbon = Convert.ToInt32(carbonLunch);
            int snackTotalCarbon = Convert.ToInt32(carbonSnack);
            int sumCarbon = breakfastTotalCarbon + dinnerTotalCarbon + lunchTotalCarbon + snackTotalCarbon;
            lblCarbon.Text = sumCarbon.ToString();
        }
        private void TakenTotalFat(string mealNameBreakFast, string mealNameLunch, string mealNameDinner, string mealNameSnack)
        {
            int id = this.id;
            var breakfastFat = _foodInfoService.GetAll(mealNameBreakFast, id).Data.ToList();
            var fatBreakfast = string.Join(", ", breakfastFat.Sum(x => x.Fat));


            var dinnerFat = _foodInfoService.GetAll(mealNameDinner, id).Data.ToList();
            var fatDinner = string.Join(", ", dinnerFat.Sum(x => x.Fat));


            var lunchFat = _foodInfoService.GetAll(mealNameLunch, id).Data.ToList();
            var fatLunch = string.Join(", ", lunchFat.Sum(x => x.Fat));


            var snackFat = _foodInfoService.GetAll(mealNameSnack, id).Data.ToList();
            var fatSnack = string.Join(", ", snackFat.Sum(x => x.Fat));


            int breakfastTotalFat = Convert.ToInt32(fatBreakfast);
            int dinnerTotalFat = Convert.ToInt32(fatDinner);
            int lunchTotalFat = Convert.ToInt32(fatLunch);
            int snackTotalFat = Convert.ToInt32(fatSnack);
            int sumFat = breakfastTotalFat + dinnerTotalFat + lunchTotalFat + snackTotalFat;
            lblYağ.Text = sumFat.ToString();
        }

        private void frmAppMainPage_Load(object sender, EventArgs e)
        {
            DisplayOnScreen();
        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmUserProfile frmUserProfile = (frmUserProfile)EFContextForm.EFContextForm.ConfigureService<frmUserProfile>();
            frmUserProfile.UserInfoIdf3 = id;
            frmUserProfile.ShowDialog();
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            frmBreakfastPage frmBreakfastPage = (frmBreakfastPage)EFContextForm.EFContextForm.ConfigureService<frmBreakfastPage>();
            frmBreakfastPage.id = id;
            frmBreakfastPage.ShowDialog();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            frmSnacks frmSnacks = (frmSnacks)EFContextForm.EFContextForm.ConfigureService<frmSnacks>();
            frmSnacks.id= id;
            frmSnacks.ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            frmLunch frmLunch = (frmLunch)EFContextForm.EFContextForm.ConfigureService<frmLunch>();
            frmLunch.id = id;
            frmLunch.ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            frmDinner frmDinner = (frmDinner)EFContextForm.EFContextForm.ConfigureService<frmDinner>();
            frmDinner.id = id;
            frmDinner.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmUserReports frmUserReports = (frmUserReports)EFContextForm.EFContextForm.ConfigureService<frmUserReports>();
            frmUserReports.id = id;
            frmUserReports.ShowDialog();
        }
    }
}
