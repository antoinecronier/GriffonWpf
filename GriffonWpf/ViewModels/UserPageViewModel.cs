using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GriffonWpf.ViewModels.Base;
using GriffonWpf.ViewModels.Events;
using GriffonWpf.ViewModels.ICommands;
using GriffonWpf.Views;
using GriffonWpfClassLibrary.Database;
using GriffonWpfClassLibrary.Entities;

namespace GriffonWpf.ViewModels
{
    public class UserPageViewModel : BaseViewModel<UserPage>
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public RemoveItemCommand RemoveItem { get; set; }

        public UserPageViewModel(UserPage userPage)
        {
            this.currentPage = userPage;
            this.LoadItems();
            this.BindItems();
        }

        private void LoadItems()
        {
            //this.currentPage.TxtB1.Text = "Bonjour";
            using (var db = new GriffonWpfContext())
            {
                foreach (var item in db.Users.ToList())
                {
                    users.Add(item);
                }
            }

            this.currentPage.listViewUsers.ItemsSource = users;

            this.RemoveItem = new RemoveItemCommand();
        }

        private void BindItems()
        {
            //this.currentPage.Btn1.Click += Btn1_Click;
            this.RemoveItem.HaveToRemoved += RemoveItem_HaveToRemoved;
            this.currentPage.UserCreateUC.UserCreated += UserCreateUC_UserCreated;
        }

        private void UserCreateUC_UserCreated(object sender, EventArgs e)
        {
            User user = (e as UserEventArgs).User;
            this.users.Add(user);
            using (var db = new GriffonWpfContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private void RemoveItem_HaveToRemoved(object sender, EventArgs e)
        {
            User user = (sender as RemoveItemCommand).ToRemoved as User;
            this.users.Remove(user);
            using (var db = new GriffonWpfContext())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
