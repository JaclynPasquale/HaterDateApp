using HaterDateApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDateApp
{
 
        public class HaterDateContext : DbContext
        {
            public DbSet<Profiles> Profile { get; set; }
            public DbSet<Dislikes> Dislike { get; set; }
            public DbSet<Questions> Question { get; set; }

        }
   
}