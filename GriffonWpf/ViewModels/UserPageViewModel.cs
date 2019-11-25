using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonWpf.Views;

namespace GriffonWpf.ViewModels
{
    public class UserPageViewModel
    {
        private UserPage userPage;

        public UserPageViewModel(UserPage userPage)
        {
            this.userPage = userPage;
            this.LoadItems();
            this.BindItems();
        }

        private void LoadItems()
        {
            this.userPage.TxtB1.Text = "Bonjour";
        }

        private void BindItems()
        {
            this.userPage.Btn1.Click += Btn1_Click;
        }

        private void Btn1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.userPage.TxtB1.Text += " coucou";
        }
    }
}
