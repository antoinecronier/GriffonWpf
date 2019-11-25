using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GriffonWpf.Views.Base
{
    public abstract class BasePage : Page
    {
        public Window GetWindow()
        {
            return Window.GetWindow(this);
        }
    }
}
