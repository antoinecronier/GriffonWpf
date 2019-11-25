using GriffonWpf.ViewModels;
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
using System.Windows.Shapes;

namespace GriffonWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private LoginViewModel vm;

        public Login()
        {
            InitializeComponent();
            this.vm = new LoginViewModel(this);

        }

        public Window GetWindow()
        {
            return Window.GetWindow(this);
        }
    }
}
