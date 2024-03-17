using CondoTech.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CondoTech.Domain.Context
{
    public interface IAppDbContext<out TContext> where TContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
    }

}
