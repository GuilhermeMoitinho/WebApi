using ApiBen10.Domain.Entities;
using ApiBen10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aliens = ApiBen10.Domain.Entities;





namespace Services
{
    public class AlienApplication : IAlienApplication
    {
        private readonly IAlienService _alienservice;

        public AlienApplication(IAlienService alienservice)
        {
            _alienservice = alienservice;
        }

        public async Task Adicionar(Aliens.AlienModel produto)
        {
            await _alienservice.Adicionar(produto);
        }

        public async Task EditarAlien(Aliens.AlienModel alienEditado, Guid id)
        {
            await _alienservice.EditarAlien(alienEditado, id);
        }

        public async Task<Aliens.AlienModel> ObterProdutoPorId(Guid id)
        {
            return await _alienservice.ObterProdutoPorId(id);
        }

        public async Task<IEnumerable<Aliens.AlienModel>> ObterTodos(int peginaNumeros, int quantNumeros)
        {
            return await _alienservice.ObterTodos(peginaNumeros, quantNumeros);
        }

        public async Task RemoverAlien(Guid idRemovido)
        {
            await _alienservice.RemoverAlien(idRemovido);
        }
    }
}