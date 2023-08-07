using DietProgram.BLL.Abstract.IServices;
using DietProgram.BLL.Concrete.Services;
using DietProgram.Models.VMs.UserInfoVm;
using DietProgram.UI.AppUI;
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
    
    public partial class frmUserProfile : Form
    {
        public int UserInfoIdf3 { get; set; }
        private readonly IUserService _userService;
        private readonly IUserInfoService _userInfoService;

        public frmUserProfile(IUserInfoService userInfoService, IUserService userService)
        {
            InitializeComponent();
            _userInfoService = userInfoService;
            _userService = userService;
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {

            var userInfos = _userInfoService.GetAll().Data;
            
            var matchingUser = userInfos.FirstOrDefault(x => x.UserId ==UserInfoIdf3 );



            if (matchingUser != null)
            {
                txtName.Text = matchingUser.Name;
                txtAge.Text = matchingUser.Age.ToString();
                string gender = matchingUser.Gender.ToString();
                if (gender == "Erkek")
                {
                    checkBoxMale.Checked = true;
                }
                else
                {
                    checkBoxFemale.Checked = true;
                }


                txtHeight.Text = matchingUser.Height.ToString();
                txtWeight.Text = matchingUser.Weight.ToString();
                txtWaistCircumference.Text = matchingUser.WCircum.ToString();
                txtNeckCircumference.Text = matchingUser.NCircum.ToString();
                txtHipCircumference.Text = matchingUser.HCircum.ToString();
                string activity = matchingUser.Activite.ToString();
                if (activity == "Az")
                {
                    rbLess.Checked = true;
                    rbMid.Checked = false;
                    rbVery.Checked = false;
                }
                else if (activity == "Orta")
                {
                    rbLess.Checked = false;
                    rbMid.Checked = true;
                    rbVery.Checked = false;
                }
                else if (activity == "çok")
                {
                    rbLess.Checked = false;
                    rbMid.Checked = false;
                    rbVery.Checked = true;
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı verilerinin aktarımı hatalı.");
            }
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;

            }

        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;

            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string gender;
            if (checkBoxFemale.Checked == true)
            {
                gender = "Kadın";
            }
            else
            {
                gender = "Erkek";
            }
            string activity = "";
            if (rbLess.Checked == true)
            {
                activity = "Az";
            }
            else if (rbMid.Checked == true)
            {
                activity = "Orta";
            }
            else if (rbVery.Checked == true)
            {
                activity = "çok";
            }

            var UserInfodata = _userInfoService.GetAll().Data.ToList();
            int UserInfoId = UserInfodata.FirstOrDefault(x => x.UserId == UserInfoIdf3).UserInfoId;
            _userInfoService.Delete(UserInfoId);



            int age = Convert.ToInt32(txtAge.Text);
            int height = Convert.ToInt32(txtHeight.Text);
            int weight = Convert.ToInt32(txtWeight.Text);



            double totalCal = 0;
            if (gender == "Kadın")
            {
                totalCal = (double)(665.10 + (9.56 * weight) + (1.85 * height) - (4.68 * age));
            }
            else if (gender == "Erkek")
            {
                totalCal = (double)(66.5 + (13.75 * weight) + (5 * height) - (6.77 * age));
            }



            UserInfoUpdateVm updateVm = new UserInfoUpdateVm()
            {
                UserInfoId = UserInfoId,
                Name = txtName.Text,
                Age = age,
                Height = height,
                Weight = weight,
                HCircum = Convert.ToInt32(txtHipCircumference.Text),
                NCircum = Convert.ToInt32(txtNeckCircumference.Text),
                WCircum = Convert.ToInt32(txtWaistCircumference.Text),
                Gender = gender,
                Activite = activity,
                UserId = UserInfoIdf3,
                TotalCalorie = (int)totalCal,
            };
            _userInfoService.Update(updateVm);
            MessageBox.Show("Bilgilerinizin başarılı bir şekilde kaydolması için tekrar oturum açmalısınız.");
            this.Close();
            frmUserLogin frmUserLogin = (frmUserLogin)EFContextForm.EFContextForm.ConfigureService<frmUserLogin>();
            frmUserLogin.ShowDialog();


        }
    }
}
