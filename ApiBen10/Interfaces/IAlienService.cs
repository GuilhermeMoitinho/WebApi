using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ApiBen10.Domain.Entities;

namespace ApiBen10.Interfaces
{
    public interface IAlienService
    {
        Task Adicionar(Alien alien);
        Task<Alien> ObterProdutoPorId(Guid id);
        Task<List<Alien>> ObterTodos(int PeginaNumeros, int QuantNumeros);
        Task EditarAlien(Alien alienEditado, Guid id);
        Task RemoverAlien(Guid idRemovido);
    }
}