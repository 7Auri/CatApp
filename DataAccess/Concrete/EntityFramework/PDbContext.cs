﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=Project;Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Health> Healths { get; set; }
        public DbSet<MaltVit> MaltVits { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<DryFood> DryFoods { get; set; }
        public DbSet<WetFood> WetFoods { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }

    }
}
