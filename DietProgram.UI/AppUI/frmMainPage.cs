using DietProgram.UI.AdminUI;
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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Form frmAdminLogin = EFContextForm.EFContextForm.ConfigureService<frmAdminLogin>();
            frmAdminLogin.ShowDialog();
            this.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmUserLogin frmUserLogin = (frmUserLogin)EFContextForm.EFContextForm.ConfigureService<frmUserLogin>();
            this.Hide();
            frmUserLogin.ShowDialog();
            this.Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Form frmCreateNewUser = EFContextForm.EFContextForm.ConfigureService<frmCreateNewUser>();
            frmCreateNewUser.ShowDialog();
            this.Close();

        }

        private void btnLogOut4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
