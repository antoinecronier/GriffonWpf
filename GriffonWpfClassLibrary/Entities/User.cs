using GriffonWpfClassLibrary.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfClassLibrary.Entities
{
    public class User : EntityNotifierBase
    {
        private String firstname;
        private String lastname;
        private DateTime dateOfBirth;
        private String login;
        private String password;

        public string Firstname { get => firstname;
            set { firstname = value; OnPropertyChanged("Firstname"); } }
        public string Lastname { get => lastname;
            set { lastname = value; OnPropertyChanged("Lastname"); } }
        public DateTime DateOfBirth { get => dateOfBirth;
            set { dateOfBirth = value; OnPropertyChanged("DateOfBirth"); } }
        public string Login { get => login;
            set { login = value; OnPropertyChanged("Login"); } }
        public string Password { get => password;
            set { password = value; OnPropertyChanged("Password"); } }

        public User()
        {

        }

        public User(String firstname, String lastname, DateTime dateOfBirth, String login, String password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateOfBirth = dateOfBirth;
            this.login = login;
            this.password = password;
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname + " " + this.DateOfBirth + " " + this.Login + " " + this.Password;
        }
    }
}
