using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GriffonWpf.ViewModels.Base;
using GriffonWpf.Views;

namespace GriffonWpf.ViewModels
{
    public class LoginPageViewModel : BaseViewModel<LoginPage>
    {
        public LoginPageViewModel(LoginPage loginPage)
        {
            this.currentPage = loginPage;
            this.LoadItems();
            this.BindItems();
        }

        private void LoadItems()
        {
            this.currentPage.txtBlockLogin.Text = "Login";
            this.currentPage.txtBlockPassword.Text = "Password";
        }

        private void BindItems()
        {
            this.currentPage.btnValidate.Click += BtnValidate_Click;
        }

        private void BtnValidate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.currentPage.txtBoxLogin.Text.Equals("toto") && this.currentPage.txtBoxPassword.Text.Equals("toto"))
            {
                this.Navigate<UserPage>();
            }
        }
    }
}
