using GriffonWpfClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
        private User _user;

        public UserCreateUC()
        {
            InitializeComponent();
            BindItems();
        }

        public UserCreateUC(User user) : this()
        {
            this._user = user;
        }

        public void BindItems()
        {
            this.btn_Validate.Click += Btn_Validate_Click; 
        }

        private void Btn_Validate_Click(object sender, RoutedEventArgs e)
        {
            User oUser = new User();

            oUser.Firstname = this.txt_FirstName.Text;
            oUser.Lastname = this.txt_LastName.Text;
            oUser.DateOfBirth = this.date_DateOfBirth.DisplayDate;
            oUser.Login = this.txt_Login.Text;
            oUser.Password = this.pas_Password.Password;
        }
    }
}
