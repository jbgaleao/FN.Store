using FN.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
    public class TipoDeProdutoMap : EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            //  TABELA
            ToTable(nameof(TipoDeProduto));

            //  PRIMARY KEY
            HasKey(pk => pk.Id);

            //  COLUNAS
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(c => c.DataCadastro);

        }
    }
}
