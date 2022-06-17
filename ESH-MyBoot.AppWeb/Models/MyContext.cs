using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ESH_MyBoot.AppWeb.Models
{
    public class MyContext : DbContext
    {
        public MyContext():base("BootDb")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}