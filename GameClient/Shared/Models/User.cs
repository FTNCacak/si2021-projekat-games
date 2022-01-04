using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public decimal Wallet { get; set; }
        public User() { }
        public User(string name, string lastname, string email, string password, string phone, decimal wallet)
        {
            Name = name;
            Lastname = lastname;
            Email = email;
            Password = password;
            Phone = phone;
            Wallet = wallet;
        }
    }
}
