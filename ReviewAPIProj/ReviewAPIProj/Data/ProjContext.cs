using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReviewAPIProj.Models;

namespace ReviewAPIProj.Data
{
    public class ProjContext : DbContext
    {
        public ProjContext (DbContextOptions<ProjContext> options)
            : base(options)
        {
        }

        public DbSet<ReviewAPIProj.Models.Product> Product { get; set; }

        public DbSet<ReviewAPIProj.Models.Request> Request { get; set; }

        public DbSet<ReviewAPIProj.Models.RequestLine> RequestLine { get; set; }

        public DbSet<ReviewAPIProj.Models.User> User { get; set; }

        public DbSet<ReviewAPIProj.Models.Vendor> Vendor { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(u =>
            {
                u.HasIndex(p => p.Username).IsUnique();

            });


            builder.Entity<Vendor>(v =>
            {
                v.HasIndex(v => v.Code).IsUnique();
            });


            builder.Entity<Product>(p =>
            {
                p.HasIndex(p => p.PartNbr).IsUnique();

            });

        }























    }



}
