using DietProgram.BLL.Abstract.IServices;
using DietProgram.Models.VMs.UserVM;
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
    public partial class frmPasswordReset : Form
    {
        private readonly IUserService _service;
        public frmPasswordReset(IUserService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUserLogin frmUserLogin = (frmUserLogin)EFContextForm.EFContextForm.ConfigureService<frmUserLogin>();
            this.Hide();
            frmUserLogin.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var getData = _service.GetAll().Data.ToList();
            int getSecurityCode = getData[0].SecurityCode;
            int codeInText = Convert.ToInt32(txtSecurityCode.Text);
            string newPassword = txtPassword.Text;
            string newPasswordAgain = txtPasswordConfirm.Text;

            if (getSecurityCode == codeInText)
            {
                if (newPassword == newPasswordAgain)
                {
                    UserUpdateVM updateVM = new UserUpdateVM()
                    {
                        Id = getData.FirstOrDefault(x => x.SecurityCode == codeInText).UserId,
                        SecurityCode = codeInText,
                        Password = txtPassword.Text,
                        PasswordConfirm = newPasswordAgain,
                    };
                    _service.Update(updateVM);
                    MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor.Lütfen bilgileri kontrol ederek tekrar deneyiniz.");
                }
            }
            else
            {
                MessageBox.Show("Bu güvenlik koduna sahip bir kullanıcı bulunamadı. Lütfen bilgileri kontrol ederek tekrar deneyiniz.");
            }
        }
    }
}
