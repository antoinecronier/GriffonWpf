using GriffonWpf.ViewModels.Events;
using GriffonWpf.Views.Utils;
using GriffonWpfClassLibrary.Entities;
using GriffonWpfClassLibrary.Entities.Validators.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
        public User User { get; set; }

        public UserCreateUC()
        {
            InitializeComponent();
            this.User = new User();
            this.DataContext = this.User;
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
            this.txtBFirstname.LostFocus += TxtBFirstname_LostFocus;
            this.txtBLastname.LostFocus += TxtBLastname_LostFocus;
        }

        private void TxtBLastname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ValidatorUtils.PropertyErrorAction("Lastname", this.User, (String errorMessage) =>
            {
                this.lblError.Content += errorMessage;
                this.lblError.Visibility = Visibility.Visible;
            }))
            {
                this.lblError.Visibility = Visibility.Collapsed;
            }
        }

        private void TxtBFirstname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ValidatorUtils.PropertyErrorAction("Firstname", this.User, (String errorMessage) =>
            {
                this.lblError.Content += errorMessage;
                this.lblError.Visibility = Visibility.Visible;
            }))
            {
                this.lblError.Visibility = Visibility.Collapsed;
            }
        }

        private void BtnValidate_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(this.User);
            if (ValidatorUtils.Validate(this.User, out _))
            {
                OnUserCreated(new UserEventArgs(this.User));
            }
            this.User = new User();
            this.DataContext = this.User;
        }

        public event EventHandler UserCreated;

        protected virtual void OnUserCreated(UserEventArgs e)
        {
            EventHandler handler = UserCreated;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
