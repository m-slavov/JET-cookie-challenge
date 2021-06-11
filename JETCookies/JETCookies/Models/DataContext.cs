using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JETCookies.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Cookie> CookieItems { get; set; }
        public DbSet<Ingredient> IngredientItems { get; set; }
        public DbSet<CookieIngredient> CookieIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CookieIngredient>()
                .HasKey(c => new { c.CookieId, c.IngredientId });
        }
    }
}
