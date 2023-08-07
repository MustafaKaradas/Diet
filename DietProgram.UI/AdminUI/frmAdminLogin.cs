using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
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

namespace DietProgram.UI.AdminUI
{
    public partial class frmAdminLogin : Form
    {
        private readonly IAdminService _adminService;

        public frmAdminLogin(IAdminService adminService)
        {
            InitializeComponent();
            _adminService = adminService;
        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = _adminService.Login(txtPassword.Text);
            if (login.HasError)
            {
                MessageBox.Show("Şifre Hatalı");
            }
            else
            {
                frmAdminMain frmAdminMainn = (frmAdminMain)EFContextForm.EFContextForm.ConfigureService<frmAdminMain>();
                this.Hide();
                frmAdminMainn.ShowDialog();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.ShowDialog();
            this.Close();
        }
    }
}
