using DietProgram.BLL.Abstract.IServices;
using DietProgram.DAL.Concrete.Context;
using DietProgram.UI.AppUI;
using DietProgram.UI.UserUI;
using Microsoft.EntityFrameworkCore;

namespace DietProgram.UI
{
    public partial class frmUserLogin : Form
    {

        private readonly IUserService _userService;
        DietProgramDbContext _dbContext;
        public frmUserLogin(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            _dbContext = new DietProgramDbContext();
        }

        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            var login = _userService.Login(txtUserName.Text, txtPassword.Text);
            if(login.HasError)
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
            }
            else
            {
                var id = _dbContext.Users.Where(x=>x.UserName==txtUserName.Text).Select(x => x.Id).FirstOrDefault();
                
                


                frmAppMainPage frmAppMainPage = (frmAppMainPage)EFContextForm.EFContextForm.ConfigureService<frmAppMainPage>();
                frmAppMainPage.id = id;
                this.Hide();
                frmAppMainPage.ShowDialog();
                this.Close();
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset frmPasswordReset = (frmPasswordReset)EFContextForm.EFContextForm.ConfigureService<frmPasswordReset>();
            this.Hide();
            frmPasswordReset.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainPage frmMainPage = (frmMainPage)EFContextForm.EFContextForm.ConfigureService<frmMainPage>();
            this.Hide();
            frmMainPage.ShowDialog();
            this.Close();
        }
    }
}