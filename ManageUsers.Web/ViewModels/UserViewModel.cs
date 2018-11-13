using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageUsers.Web.ViewModels
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool AccountStatus { get; set; }
    }
}