using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfClassLibrary.Entities
{
    public class User
    {
        private String firstname;
        private String lastname;
        private DateTime dateOfBirth;
        private String login;
        private String password;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

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
    }
}
