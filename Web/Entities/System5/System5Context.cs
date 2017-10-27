using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Entities
{
    public partial class MySqlContext: DbContext
    {
        static MySqlContext()
        {
            Database.SetInitializer<MySqlContext>(null);
        }

        public MySqlContext(string connString) : base(connString)
        {
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<Status> Status { get; set; }


    }
}