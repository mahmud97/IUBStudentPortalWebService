using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UserPortalWebService.Models
{
    public class MainDataContext:DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admin { get; set; }

        //public System.Data.Entity.DbSet<UserPortalWebService.Models.ChangePassword> ChangePasswords { get; set; }
    }
}