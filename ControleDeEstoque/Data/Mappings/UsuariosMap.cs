using ControleDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SuiteMartinelli.Module.Data.Mapping.GlobalMap
{
    public class UsuariosMap : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> entity)
        {

            entity.HasKey(e => e.Id).HasName("PK_Usuarios");

            entity.Property(e => e.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            entity.Property(e => e.Id).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Login).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            entity.Property(e => e.Senha).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        }
    }
}
