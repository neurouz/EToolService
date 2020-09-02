using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Model.Requests
{
    public class CustomerUpdateRequest
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int AreaId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
