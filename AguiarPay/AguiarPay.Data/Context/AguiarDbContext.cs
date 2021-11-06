using AguiarPay.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AguiarPay.Data.Context
{
    public class AguiarDbContext : DbContext
    {
        public AguiarDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AguiarDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ComandaColetiva> ComandasColetivas { get; set; }
        public DbSet<ComandaIndividual> ComandasIndividuais { get; set; }
        public DbSet<PedidoColetivo> PedidosColetivos { get; set; }
        public DbSet<PedidoIndividual> PedidosIndividuais { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
