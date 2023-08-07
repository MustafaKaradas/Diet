using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Models.VMs.UserInfoVm;
using DietProgram.Models.VMs.UserVM;
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
    public partial class frmNewUser3 : Form

    {
        public string UserName { get; set; }
        public string Genderf3 { get; set; }
        public string NameValuef3 { get; set; }
        public int AgeValuef3 { get; set; }
        public int HeightValuef3 { get; set; }
        public int WeightValuef3 { get; set; }
        public int? HCircumf3 { get; set; }
        public int? WCircumf3 { get; set; }
        public int? NCircumf3 { get; set; }
        public int TotalCal { get; set; }

        private readonly IUserInfoService _userInfoService;
        private readonly IUserService _userService;
        DietProgramDbContext _dbContext;
        public frmNewUser3(IUserInfoService userInfoService, IUserService userService)
        {
            InitializeComponent();
            _userInfoService = userInfoService;
            _dbContext = new DietProgramDbContext();
            _userService = userService;
        }

        private void btnLogOut4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLessActive_Click(object sender, EventArgs e)
        {
            GetPropsLowActive();

        }

        private void GetPropsLowActive()
        {
            string UserName = this.UserName;
            int userID = _dbContext.Users.FirstOrDefault(x => x.UserName == this.UserName).Id;
            UserInfoCreateVm userInfoCreateVm = new UserInfoCreateVm()
            {
                UserInfoId = userID,
                Gender = Genderf3,
                Name = NameValuef3,
                Age = AgeValuef3,
                Weight = WeightValuef3,
                Height = HeightValuef3,
                HCircum = HCircumf3,
                WCircum = WCircumf3,
                NCircum = NCircumf3,
                Activite = "Az",
                TotalCalorie = (int)(CalculateCalories() * 1.2),

                UserId = userID
            };
            
            var data = _userInfoService.Create(userInfoCreateVm);               
            if (data.HasError)
            {
                MessageBox.Show("Kayıt başarısız");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı");

                frmUserLogin frmUserLogin = (frmUserLogin)EFContextForm.EFContextForm.ConfigureService<frmUserLogin>();
                this.Hide();
                frmUserLogin.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// This method is created to display the data in the user information table in the relevant texts.
        /// </summary>
        /// <returns></returns>
        private double CalculateCalories()
        {
            double totalCal = 0;
            if (Genderf3 == "Kadın")
            {
                totalCal = (double)(655.10 + (9.56 * WeightValuef3) + (1.85 * HeightValuef3) - (4.68 * AgeValuef3));

                return totalCal;
            }
            else
            {
                totalCal = (double)(66.5 + (13.75 * WeightValuef3) + (5 * HeightValuef3) - (6.77 * AgeValuef3));

                return totalCal;
            }
        }



        private void btnMidActive_Click(object sender, EventArgs e)
        {
            GetPropsMidActive();
        }

        private void GetPropsMidActive()
        {
            int userID = _dbContext.Users.Select(x => x.Id).FirstOrDefault();
            UserInfoCreateVm userInfoCreateVm = new UserInfoCreateVm()
            {
                Gender = Genderf3,
                Name = NameValuef3,
                Age = AgeValuef3,
                Weight = WeightValuef3,
                Height = HeightValuef3,
                HCircum = HCircumf3,
                WCircum = WCircumf3,
                NCircum = NCircumf3,
                Activite = "Orta",
                TotalCalorie = (int)(CalculateCalories() * 1.4),
                UserId = userID
            };
            var data = _userInfoService.Create(userInfoCreateVm);
            if (data.HasError)
            {
                MessageBox.Show("Kayıt başarısız");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı");

                frmUserLogin frmUserLogin = (frmUserLogin)EFContextForm.EFContextForm.ConfigureService<frmUserLogin>();
                this.Hide();
                frmUserLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            GetPropsVeryActive();
        }

        private void GetPropsVeryActive()
        {
            int userID = _dbContext.Users.Select(x => x.Id).FirstOrDefault();
            UserInfoCreateVm userInfoCreateVm = new UserInfoCreateVm()
            {
                Gender = Genderf3,
                Name = NameValuef3,
                Age = AgeValuef3,
                Weight = WeightValuef3,
                Height = HeightValuef3,
                HCircum = HCircumf3,
                WCircum = WCircumf3,
                NCircum = NCircumf3,
                Activite = "çok",
                TotalCalorie = (int)(CalculateCalories() * 1.5),
                UserId = userID

            };
            var data = _userInfoService.Create(userInfoCreateVm);
            if (data.HasError)
            {
                MessageBox.Show("Kayıt başarısız");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı");

                frmUserLogin frmUserLogin = (frmUserLogin)EFContextForm.EFContextForm.ConfigureService<frmUserLogin>();
                this.Hide();
                frmUserLogin.ShowDialog();
                this.Close();
            }
        }
    }
}
