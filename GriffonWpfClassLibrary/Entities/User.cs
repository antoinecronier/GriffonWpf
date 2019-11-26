using GriffonWpfClassLibrary.Entities.Base;
using GriffonWpfClassLibrary.Entities.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfClassLibrary.Entities
{
    public class User : EntityNotifierBase, EntityDb
    {
        private long id;

        private String firstname;
        private String lastname;
        private DateTime dateOfBirth;
        private String login;
        private String password;
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        [NameValidator(5,8)]
        public string Firstname { get => firstname;
            set { firstname = value; OnPropertyChanged("Firstname"); } }

        [Required]
        [NameValidator(6,24)]
        public string Lastname { get => lastname;
            set { lastname = value; OnPropertyChanged("Lastname"); } }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get => dateOfBirth;
            set { dateOfBirth = value; OnPropertyChanged("DateOfBirth"); } }

        [Required]
        public string Login { get => login;
            set { login = value; OnPropertyChanged("Login"); } }

        [Required]
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
