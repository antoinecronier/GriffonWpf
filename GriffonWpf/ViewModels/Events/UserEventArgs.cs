using GriffonWpfClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpf.ViewModels.Events
{
    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }

        public UserEventArgs(User user)
        {
            this.User = user;
        }
    }
}
