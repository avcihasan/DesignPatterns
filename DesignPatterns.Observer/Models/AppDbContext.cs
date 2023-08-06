﻿using DesignPatterns.Observer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Strategy.Models
{
    public class AppDbContext:IdentityDbContext<AppUser,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        public DbSet<Discount> Discounts { get; set; }
    }
}
