using Microsoft.EntityFrameworkCore;
using MyStore.Core.Domain.Entities;

namespace MyStore.Core.Infra.Maps
{

    public static class ClienteMap
    {
        public static ModelBuilder MapCliente(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity
                .HasKey(x => x.Id);

                entity.OwnsOne(x => x.CPF)
                   .Property(x => x.Value)
                   .HasColumnName("CPF")
                   .HasColumnType("varchar(14)")
                   .HasMaxLength(14)
                   .IsRequired();

                entity.OwnsOne(x => x.Nome)
                  .Property(x => x.Value)
                  .HasColumnName("Nome")
                  .HasMaxLength(255)
                  .IsRequired();

                entity.Property(x => x.DataNascimento)
                .HasColumnName("DT_Nascimento");

            });
            return modelBuilder;
        }
    }
}
