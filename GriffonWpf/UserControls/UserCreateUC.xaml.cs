using GriffonWpf.Views.Utils;
using GriffonWpfClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GriffonWpf.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UserCreateUC.xaml
    /// </summary>
    public partial class UserCreateUC : UserControl
    {
        public UserCreateUC()
        {
            InitializeComponent();
            this.LoadItems();
            this.BindItems();
        }

        private void LoadItems()
        {
            this.lblFirstname.Content = "Firstname";
            this.lblDateOfBirth.Content = "Date of birth";
            this.lblLastname.Content = "Lastname";
            this.lblLogin.Content = "Login";
            this.lblPassword.Content = "Password";
        }

        private void BindItems()
        {
            this.btnValidate.Click += BtnValidate_Click;
        }

        private void BtnValidate_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(
                this.txtBFirstname.Text, 
                this.txtBLastname.Text, 
                DateTime.Parse(this.datepickerDateOfBirth.Text), 
                this.txtBLogin.Text, 
                this.txtBPassword.Text);
            Console.WriteLine(user);
        }
    }
}
