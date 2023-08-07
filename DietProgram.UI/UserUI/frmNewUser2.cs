using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Models.VMs.UserInfoVm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DietProgram.UI.AppUI
{
    public partial class frmNewUser2 : Form

    {
        public string UserName { get; set; }
        public string Genderf2 { get; set; }
        public string NameValuef2 { get; set; }
        public int AgeValuef2 { get; set; }
        public int HeightValuef2 { get; set; }
        public int WeightValuef2 { get; set; }

        private readonly IUserInfoService _userInfoService;
        DietProgramDbContext _dbContext;
        public frmNewUser2(IUserInfoService userInfoService)
        {
            InitializeComponent();
            _userInfoService = userInfoService;
            _dbContext = new DietProgramDbContext();
        }


        private static void IsDigit(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Sadece sayı giriniz!");

            }
        }

        private void txtWaistCircumference_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtNeckCircumference_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtHipCircumference_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtWaistCircumference_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWaistCircumference.Text) || !int.TryParse(txtWaistCircumference.Text, out int hcircum))
            {

                MessageBox.Show("Lütfen geçerli bir bel çevresi giriniz.");
                return;
            }

            if (hcircum < 0 || hcircum > 100)
            {

                MessageBox.Show("Lütfen geçerli bir bel çevresi giriniz (0-100 aralığında).");
                txtWaistCircumference.Clear();
                return;
            }
        }

        private void txtNeckCircumference_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNeckCircumference.Text) || !int.TryParse(txtNeckCircumference.Text, out int hcircum))
            {

                MessageBox.Show("Lütfen geçerli bir boyun çevresi giriniz.");
                return;
            }

            if (hcircum < 0 || hcircum > 100)
            {

                MessageBox.Show("Lütfen geçerli bir boyun çevresi giriniz (0-100 aralığında).");
               txtNeckCircumference.Clear();
                return;
            }
        }

        private void txtHipCircumference_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHipCircumference.Text) || !int.TryParse(txtHipCircumference.Text, out int hcircum))
            {

                MessageBox.Show("Lütfen geçerli bir kalça çevresi giriniz.");
                return;
            }

            if (hcircum < 0 || hcircum > 100)
            {

                MessageBox.Show("Lütfen geçerli bir kalça çevresi giriniz (0-100 aralığında).");
                txtHipCircumference.Clear();
                return;
            }
        }

        private void btnLogOut4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (txtHipCircumference.Text.Length == 0 || txtNeckCircumference.Text.Length == 0 || txtWaistCircumference.Text.Length == 0)     // Tüm bilgilerin eksiksiz girildiğini kontrol eder
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Giriniz!");
            }
            else
            {
                UserInfoCreateVm createVm = new UserInfoCreateVm()
                {
                    Gender = Genderf2,
                    Name = NameValuef2,
                    Age = AgeValuef2,
                    Weight = WeightValuef2,
                    Height = HeightValuef2,

                    HCircum = Convert.ToInt32(txtHipCircumference.Text),
                    WCircum = Convert.ToInt32(txtWaistCircumference.Text),
                    NCircum = Convert.ToInt32(txtNeckCircumference.Text),
                };

                frmNewUser3 frmNewUser3 = (frmNewUser3)EFContextForm.EFContextForm.ConfigureService<frmNewUser3>();
                frmNewUser3.UserName = this.UserName;
                frmNewUser3.Genderf3 = createVm.Gender;
                frmNewUser3.NameValuef3 = createVm.Name;
                frmNewUser3.AgeValuef3 = createVm.Age;
                frmNewUser3.WeightValuef3 = createVm.Weight;
                frmNewUser3.HeightValuef3 = createVm.Height;
                frmNewUser3.HCircumf3 = createVm.HCircum;
                frmNewUser3.WCircumf3 = createVm.WCircum;
                frmNewUser3.NCircumf3 = createVm.NCircum;

                this.Hide();
                frmNewUser3.ShowDialog();
                this.Close();
            }
        }
    }
}
