using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Models.VMs.UserInfoVm;
using DietProgram.UI.AdminUI;
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
    public partial class frmNewUser1 : Form
    {
        private string Genderf1 { get; set; }
        public string UserName { get; set; }

        private readonly IUserService _userService;
        private readonly IUserInfoService _userInfoService;
        public frmNewUser1(IUserService userService, IUserInfoService userInfoService)
        {
            InitializeComponent();
            _userService = userService;
            _userInfoService = userInfoService;
        }

        private void frmNewUser1_Load(object sender, EventArgs e)
        {
            btnForward.Enabled = false;


        }

        private void btnLogOut4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
                btnForward.Enabled = true;

            }
            else
            {
                btnForward.Enabled = false;
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
                btnForward.Enabled = true;
            }
            else
            {
                btnForward.Enabled = false;
            }
        }

        private static void IsLetter(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Sadece Harf giriniz!");

            }
        }
        private static void IsDigit(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Sadece sayı giriniz!");

            }
        }
        private void btnForward_Click(object sender, EventArgs e)
        {
            try
            {
                int height = Convert.ToInt32(txtHeight.Text);
                if (height < 50 && height > 260)
                {
                    MessageBox.Show("Lütfen 50-260 aralığında boy değeri giriniz");
                    txtHeight.Clear();
                }


                if (txtHeight.Text.Length == 0 || txtAge.Text.Length == 0 || txtName.Text.Length == 0 || txtWeight.Text.Length == 0)     // Tüm bilgilerin eksiksiz girildiğini kontrol eder
                {
                    MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Giriniz!");
                }
                else
                {
                    if (checkBoxFemale.Checked == true)
                    {
                        Genderf1 = "Kadın";
                    }
                    else
                    {
                        Genderf1 = "Erkek";
                    }

                    UserInfoCreateVm createVm = new UserInfoCreateVm()
                    {
                        Gender = Genderf1,
                        Name = txtName.Text,
                        Age = Convert.ToInt32(txtAge.Text),
                        Weight = Convert.ToInt32(txtWeight.Text),
                        Height = Convert.ToInt32(txtHeight.Text),

                    };
                    frmNewUser2 frmNewUser2 = (frmNewUser2)EFContextForm.EFContextForm.ConfigureService<frmNewUser2>();


                    frmNewUser2.UserName = this.UserName;
                    frmNewUser2.Genderf2 = createVm.Gender;
                    frmNewUser2.NameValuef2 = createVm.Name;
                    frmNewUser2.AgeValuef2 = createVm.Age;
                    frmNewUser2.WeightValuef2 = createVm.Weight;
                    frmNewUser2.HeightValuef2 = createVm.Height;

                    this.Hide();
                    frmNewUser2.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Doğru Bilgi Giriniz");
            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsLetter(e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(e);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text) || !int.TryParse(txtAge.Text, out int age))
            {

                MessageBox.Show("Lütfen geçerli bir yaş girin.");
                return;
            }

            if (age < 0 || age > 100)
            {

                MessageBox.Show("Lütfen geçerli bir yaş girin (0-100 aralığında).");
                txtAge.Clear();
                return;
            }

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidHeight(txtHeight.Text))
            {
                MessageBox.Show("50-260cm arası boy değeri giriniz", "Hata",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Text = "";
            }

        }
        private bool IsValidHeight(string input)
        {

            if (int.TryParse(input, out int height))
            {
                if (height >= 0 && height <= 260 )
                {
                    return true;
                }
            }
            return false;
        }


        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidWeight(txtWeight.Text))
            {
                MessageBox.Show("0-260kg arası kilo değeri giriniz", "Hata",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Text = "";
            }
        }
        private bool IsValidWeight(string input)
        {
            if (int.TryParse(input, out int weight))
            {

                if (weight > 0 && weight <= 260)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
