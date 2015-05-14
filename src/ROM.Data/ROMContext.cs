using System.ComponentModel;
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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Ignore<PropertyChangedEventHandler>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<Account>().HasKey<int>(e => e.AccountId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Table>().HasKey<int>(e => e.TableId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Order>().HasKey<int>(e => e.OrderId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Food>().HasKey<int>(e => e.FoodId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Ingridient>().HasKey<int>(e => e.IngridientId).Ignore(e => e.EntityId);
        }

    }
}
