using Microsoft.EntityFrameworkCore;
using NovaApiTraining.DTOs;

namespace NovaApiTraining.Data
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {
        }

        public DbSet<Crypto> Infos { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}