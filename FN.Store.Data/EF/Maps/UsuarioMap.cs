using FN.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //  TABELA
            ToTable(nameof(Usuario));

            //  PRIMARY KEY
            HasKey(pk => pk.Id);

            //  COLUNAS
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(c => c.Email).HasColumnType("varchar").HasMaxLength(80).IsRequired();
            Property(c => c.Senha).HasColumnType("char").HasMaxLength(88).IsRequired();
            Property(c => c.DataCadastro);
        }
    }
}
