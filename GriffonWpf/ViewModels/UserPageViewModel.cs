using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonWpf.ViewModels.Base;
using GriffonWpf.Views;

namespace GriffonWpf.ViewModels
{
    public class UserPageViewModel : BaseViewModel<UserPage>
    {
        public UserPageViewModel(UserPage userPage)
        {
            this.currentPage = userPage;
            this.LoadItems();
            this.BindItems();
        }

        private void LoadItems()
        {
            this.currentPage.TxtB1.Text = "Bonjour";
        }

        private void BindItems()
        {
            this.currentPage.Btn1.Click += Btn1_Click;
        }

        private void Btn1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.currentPage.TxtB1.Text += " coucou";
        }
    }
}
