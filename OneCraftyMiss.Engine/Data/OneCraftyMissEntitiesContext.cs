using Microsoft.EntityFrameworkCore;
using System;

namespace OneCraftyMiss.Engine.Data
{
    public class OneCraftyMissEntitiesContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

        public OneCraftyMissEntitiesContext(DbContextOptions<OneCraftyMissEntitiesContext> options)
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
    }
}
