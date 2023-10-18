using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBen10.Domain.Entities;

namespace ApiBen10.Interfaces
{
    public interface IAlienApplication
    {
        Task Adicionar(Alien produto);
        Task<Alien> ObterProdutoPorId(Guid id);
        Task<List<Alien>> ObterTodos(int PeginaNumeros, int QuantNumeros);
        Task EditarAlien(Alien alienEditado, Guid id);
        Task RemoverAlien(Guid idRemovido);
    }
}