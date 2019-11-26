using GriffonWpf.ViewModels;
using GriffonWpf.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace GriffonWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage
    {
        private LoginPageViewModel vm;

        public LoginPage()
        {
            InitializeComponent();
            vm = new LoginPageViewModel(this);
            this.Loaded += LoginPage_Loaded;
        }

        private void LoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigating += NavigationService_Navigating;
            (this.Parent as NavigationWindow).ShowsNavigationUI = false;

            this.Freeze();
        }

        private void Freeze()
        {
            Task.Factory.StartNew(() =>
            {
                Task.Delay(TimeSpan.FromMilliseconds(50)).Wait();

                Application.Current.Dispatcher.Invoke(DispatcherPriority.Send, new ThreadStart(delegate
                {
                    int i = 0;
                    while (true)
                    {
                        this.lblThread.Content = i;
                        Console.WriteLine(i);
                        i++;
                    }
                }));
            });
        }

        private Task Freezer()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private void NavigationService_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Forward)
            {
                e.Cancel = true;
            }
            else if (e.NavigationMode == NavigationMode.New && this.Parent != null)
            {
                (this.Parent as NavigationWindow).ShowsNavigationUI = true;
            }
        }
    }
}
