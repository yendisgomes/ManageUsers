using ManageUsers.Web.ViewModels.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageUsers.Web.Repositories
{
    public class RepositoryUser : RepositoryBase<ApplicationUser>
    {
        private IdentityDbContext contextUser = new IdentityDbContext();

        public IdentityUser GetById(string userId)
        {
            return contextUser.Users.Find(userId);
        }
    }
}