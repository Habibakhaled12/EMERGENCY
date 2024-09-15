using emergency.core;
using emergency.core.entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emergency.reposatoryy.dbcontext
{
   
        public class appdbcontext : IdentityDbContext<signup>
        {
            public appdbcontext(DbContextOptions<appdbcontext> options) : base(options)
            {

            }
        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },

            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "User",
                NormalizedName = "user",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            }
                );

            base.OnModelCreating(builder);
        }
        public DbSet<signup> signup { get; set; }
       
        public DbSet<Hospital> Hospitals { get; set; }
    }
}
