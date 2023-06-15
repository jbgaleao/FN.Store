using FN.Store.Domain.Entities;
using System.Data.Entity;

namespace FN.Store.Data.EF
{
    public class FNStoreDataContext : DbContext
    {
        public FNStoreDataContext() : base("StoreConn")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
