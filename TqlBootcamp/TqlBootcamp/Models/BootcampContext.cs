using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TqlBootcamp.Models
{ // building DB from scratch
    public class BootcampContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentScore> AssessmentScores { get; set; }

        
        // so application can talk to sqlsServer
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress01;database=BootcampDb;trusted_connection=true;";
                builder.UseSqlServer(connStr); // ties code to rest of sql database.. which server its on. 
            }

        } 

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }



    }
}
