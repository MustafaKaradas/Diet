using DietProgram.BLL.Abstract.IServices;
using DietProgram.Core.IBaseRepositories;
using DietProgram.DAL.Abstract;
using DietProgram.DAL.Base.EntityFramework;
using DietProgram.DAL.Concrete.Context;
using DietProgram.DAL.Concrete.Repositories;
using DietProgram.Entities;
using DietProgram.Models.VMs.UserVM;
using DietProgram.UI.AdminUI;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = DietProgram.Entities.User;

namespace DietProgram.UI.AppUI
{
    public partial class frmCreateNewUser : Form
    {
        private static IUserService _service;
        public frmCreateNewUser(IUserService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void frmCreateNewUser_Load(object sender, EventArgs e)
        {
            txtSecurityCode.Enabled = false;
            Random rnd = new Random();
            txtSecurityCode.Text = rnd.Next(100000, 900000).ToString();
        }

        private void btnLogOut4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainPage frm = new frmMainPage();
            frm.ShowDialog();
            this.Close();

        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {

            int security = Convert.ToInt32(txtSecurityCode.Text);
            int idCount = 0;
            if (_service.GetAll().Data.Count == 0)
            {
                idCount = 1;
                string password = txtPassword.Text;
                string specialCharacters = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
                int ozelKarakterSayaci = 0;
                int buyukHarfSayaci = 0;
                int kucukHarfSayaci = 0;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        if (specialCharacters.Contains(c))
                            ozelKarakterSayaci++;
                        buyukHarfSayaci++;
                    }
                    else if (char.IsLower(c))
                    {
                        kucukHarfSayaci++;
                    }
                }
                if (password.Length >= 8 && buyukHarfSayaci >= 2 && kucukHarfSayaci >= 3)
                {
                    UserCreateVM userCreateVM = new UserCreateVM()
                    {
                        UserInfoID = idCount,
                        UserName = txtUserName.Text,
                        Password = password,
                        SecurityCode = security
                    };
                    var data = _service.Create(userCreateVM);
                    var userData = _service.GetAll().Data.ToList();
                    var getUserId = userData.Select(x => x.UserId);
                    if (data.HasError)
                    {
                        MessageBox.Show("Test");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarılı");
                        frmNewUser1 frm = (frmNewUser1)EFContextForm.EFContextForm.ConfigureService<frmNewUser1>();
                        frm.UserName = userCreateVM.UserName;
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    if (password.Length <= 8)
                        MessageBox.Show("Girdiğiniz şifre 8 karakter olmalıdır");
                    if (password.Length >= 8 && buyukHarfSayaci <= 2)
                        MessageBox.Show("Girdiğiniz şifre en az iki büyük harf içermelidir.");
                    if (password.Length >= 8 && kucukHarfSayaci <= 3)
                        MessageBox.Show("Girdiğiniz şifre en az 3 küçük karakter içermelidir.");
                }

            }
            else
            {
                string password = txtPassword.Text;
                string specialCharacters = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
                int ozelKarakterSayaci = 0;
                int buyukHarfSayaci = 0;
                int kucukHarfSayaci = 0;
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        if (specialCharacters.Contains(c))
                            ozelKarakterSayaci++;
                        buyukHarfSayaci++;
                    }
                    else if (char.IsLower(c))
                    {
                        kucukHarfSayaci++;
                    }
                }

                if (password.Length >= 8 && buyukHarfSayaci >= 2 && kucukHarfSayaci >= 3)
                {
                    UserCreateVM userCreateVM = new UserCreateVM()
                    {
                        UserInfoID = Convert.ToInt32(_service.GetAll().Data.Last().UserInfoId) + 1,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                        SecurityCode = security
                    };

                    var data = _service.Create(userCreateVM);
                    var userData = _service.GetAll().Data.ToList();
                    var getUserId = userData.Select(x => x.UserId);
                    if (data.HasError)
                    {
                        MessageBox.Show("Test");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarılı");
                        frmNewUser1 frm = (frmNewUser1)EFContextForm.EFContextForm.ConfigureService<frmNewUser1>();
                        frm.UserName = userCreateVM.UserName;
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    if (password.Length <= 8)
                        MessageBox.Show("Girdiğiniz şifre 8 karakter olmalıdır");
                    if (password.Length >= 8 && buyukHarfSayaci <= 2)
                        MessageBox.Show("Girdiğiniz şifre en az iki büyük harf içermelidir.");
                    if (password.Length >= 8 && kucukHarfSayaci <= 3)
                        MessageBox.Show("Girdiğiniz şifre en az 3 küçük karakter içermelidir.");

                }

            }

        }

        private void btnSoru_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Şifrenizi unuttuğunuzda yenilemeniz için güvenlik koduna ihtiyacınız olacak. Lütfen bu bilgiyi unutmayınız!";
        }
    }
}
