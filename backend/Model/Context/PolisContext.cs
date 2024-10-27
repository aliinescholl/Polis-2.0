using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Reflection;

namespace Model.Context
{
    public class PolisContext : DbContext
    {
        public PolisContext(DbContextOptions<PolisContext> options) : base(options) { }
        
        public DbSet<Autor> Meta { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
