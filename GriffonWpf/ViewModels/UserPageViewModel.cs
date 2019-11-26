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
            users.Add(new User("u1", "lu1", DateTime.Now, "l1", "p1"));
            users.Add(new User("u2", "lu2", DateTime.Now, "l2", "p2"));
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
            this.users.Add((e as UserEventArgs).User);
        }

        private void Btn1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //this.currentPage.TxtB1.Text += " coucou";
        }

        private void RemoveItem_HaveToRemoved(object sender, EventArgs e)
        {
            this.users.Remove((sender as RemoveItemCommand).ToRemoved as User);
        }
    }
}
