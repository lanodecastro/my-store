using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using MyStore.Core.Domain.Entities;
using MyStore.Core.Infra.Maps;

namespace MyStore.Core.Infra
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<Cliente> ClinteDbSet { get; set; }

        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            modelBuilder.MapCliente();

        }

    }
}
