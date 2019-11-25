using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GriffonWpf.Views;

namespace GriffonWpf.ViewModels
{
    public class LoginPageViewModel
    {
        private LoginPage loginPage;

        public LoginPageViewModel(LoginPage loginPage)
        {
            this.loginPage = loginPage;
            this.LoadItems();
            this.BindItems();
        }

        private void LoadItems()
        {
            this.loginPage.txtBlockLogin.Text = "Login";
            this.loginPage.txtBlockPassword.Text = "Password";
        }

        private void BindItems()
        {
            this.loginPage.btnValidate.Click += BtnValidate_Click;
        }

        private void BtnValidate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.loginPage.txtBoxLogin.Text.Equals("toto") && this.loginPage.txtBoxPassword.Text.Equals("toto"))
            {
                this.loginPage.GetWindow().Content = new UserPage();
            }
        }
    }
}
