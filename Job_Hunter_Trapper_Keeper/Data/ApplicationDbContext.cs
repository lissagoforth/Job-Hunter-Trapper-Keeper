﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Job_Hunter_Trapper_Keeper.Models;

namespace Job_Hunter_Trapper_Keeper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Company> Company { get; set; }

        public DbSet<CompanyNotes> CompanyNotes { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<ContactNotes> ContactNotes { get; set; }

        public DbSet<Job> Job { get; set; }

        public DbSet<JobContact> JobContact { get; set; }

        public DbSet<JobNotes> JobNotes { get; set; }
    }
}
