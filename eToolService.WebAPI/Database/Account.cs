using System;
using System.Collections.Generic;

namespace EToolService.WebAPI.Database
{
    public class Account
    {
        public Account()
        {
            Administrator = new HashSet<Administrator>();
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Administrator> Administrator { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
