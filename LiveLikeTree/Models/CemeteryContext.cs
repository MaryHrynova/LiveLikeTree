using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveLikeTree.Models
{
    public class CemeteryContext : DbContext
    {
        public DbSet<Tree> Trees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TreeType> TreeTypes { get; set; }


    }
}