using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jyy201831980105.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Jyy201831980105.Models.Xueshengxinxi> Xueshengxinxis { get; set; }

        public System.Data.Entity.DbSet<Jyy201831980105.Models.chengji> chengjis { get; set; }
    }
}