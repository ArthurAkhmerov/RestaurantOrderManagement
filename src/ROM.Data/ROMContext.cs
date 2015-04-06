using System.Data.Entity;
using ROM.Business.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Serialization;
using Core.Common.Contracts;

namespace ROM.Data
{
    public class ROMContext : DbContext
    {
        public ROMContext()
            : base("name=ROM")
        {
            Database.SetInitializer<ROMContext>(null);
        }

        public DbSet<Account> AccountSet { get; set; }

        public DbSet<Order> OrderSet { get; set; }

        public DbSet<Table> TableSet { get; set; }

        public DbSet<Food> FoodSet { get; set; }

        public DbSet<Ingridient> IngridientSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // TODO: bindings...
        }

    }
}
