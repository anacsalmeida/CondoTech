﻿using CondoTech.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CondoTech.Domain.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        { }
        public DbSet<User>? Users { get; set; }
    }
}
