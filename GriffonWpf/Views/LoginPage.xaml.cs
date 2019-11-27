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
            AutoResetEvent aRe = new AutoResetEvent(false);

            Action a1 = () =>
            {
                Task.Delay(TimeSpan.FromMilliseconds(50)).Wait();

                int i = 0;
                while (true)
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Send, new ThreadStart(delegate
                    {

                        this.lblThread.Content = i;

                    }));
                    if (i == 10000)
                    {
                        aRe.Set();
                    }
                    Console.WriteLine(i);
                    i++;
                }
            };
            
            Task.Factory.StartNew(a1);

            Task.Factory.StartNew(() =>
            {
                if (aRe.WaitOne())
                {
                    Console.WriteLine("finish");
                }
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
