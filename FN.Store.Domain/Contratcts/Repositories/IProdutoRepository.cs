using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Domain.Contratcts.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetByNameContains(string contains);
    }
}
