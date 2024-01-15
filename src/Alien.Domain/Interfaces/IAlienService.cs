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
        Task Adicionar(AlienModel alien);
        Task<AlienModel> ObterProdutoPorId(Guid id);
        Task<IEnumerable<AlienModel>> ObterTodos(int PeginaNumeros, int QuantNumeros);
        Task EditarAlien(AlienModel alienEditado, Guid id);
        Task RemoverAlien(Guid idRemovido);
    }
}