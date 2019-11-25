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
        public BasePage()
        {
            this.Loaded += BasePage_Loaded;
        }

        private void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            int minHeight = 0;
            if (int.TryParse(GriffonWpf.Properties.Resources.AppMinHeight,out minHeight))
            {
                this.GetWindow().MinHeight = minHeight;
            }
            else
            {
                this.GetWindow().MinHeight = ViewsConstantes.DEFAULT_MIN_HEIGHT;
            }

            int minWidth = 0;
            if (int.TryParse(GriffonWpf.Properties.Resources.AppMinWidth, out minWidth))
            {
                this.GetWindow().MinWidth = minWidth;
            }
            else
            {
                this.GetWindow().MinWidth = ViewsConstantes.DEFAULT_MIN_WIDTH;
            }
        }

        public Window GetWindow()
        {
            return Window.GetWindow(this);
        }
    }
}
