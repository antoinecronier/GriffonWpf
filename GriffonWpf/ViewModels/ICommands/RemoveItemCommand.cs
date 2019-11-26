using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GriffonWpf.ViewModels.ICommands
{
    public class RemoveItemCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public object ToRemoved { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object sender)
        {
            this.ToRemoved = sender;
            OnHaveToRemoved(new EventArgs());
        }

        public event EventHandler HaveToRemoved;

        protected virtual void OnHaveToRemoved(EventArgs e)
        {
            EventHandler handler = HaveToRemoved;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
