using GriffonWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GriffonWpf.ViewModels
{
    public class LoginViewModel
    {
        private Login login;

        public LoginViewModel(Login login)
        {
            this.login = login;
            this.LoadItems();
            this.BindingItems();
        }

        private void LoadItems()
        {

        }
        private void BindingItems()
        {
            this.login.btnValidateLogin.Click += BtnValidateLogin_Click;
        }

        private void BtnValidateLogin_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.login.txtLogin.Text.Equals("toto") && this.login.txtPassword.Text.Equals("toto"))
            {
                this.login.GetWindow().Content = new UserPage();
            }
        }
    }
}
