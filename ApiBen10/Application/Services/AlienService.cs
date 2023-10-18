using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ApiBen10.DataContext;
using ApiBen10.Domain.Entities;
using ApiBen10.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiBen10.Application.Services
{
    public class AlienService : IAlienService
    {
        private readonly AppDbContext _alienservice;

        public AlienService(AppDbContext alienservcie)
        {
            _alienservice = alienservcie;
        }

        public async Task Adicionar(Alien alien)
        {
            _alienservice.Add(alien);
            await _alienservice.SaveChangesAsync();

            await Task.CompletedTask;
        }

        public async Task EditarAlien(Alien alienEditado, Guid id)
        {
            var EncontrarId = _alienservice.Aliens.Find(id);

            EncontrarId.NomeAlien = alienEditado.NomeAlien;
            EncontrarId.NumeroDoAlien = alienEditado.NumeroDoAlien;
            EncontrarId.HorarioDeCadastro = DateTime.Now;

            _alienservice.Aliens.Update(EncontrarId);
            await _alienservice.SaveChangesAsync();
        }

        public async Task<Alien> ObterProdutoPorId(Guid id)
        {
            return await _alienservice.Aliens.FindAsync(id);
        }

        public async Task<List<Alien>> ObterTodos(int peginaNumeros, int quantNumeros)
        {
            var TodosAliens = await _alienservice.Aliens

            .Skip(peginaNumeros * quantNumeros)
            .Take(quantNumeros)
            .ToListAsync(); 

            return TodosAliens;
        }

        public async Task RemoverAlien(Guid idRemovido)
        {
            var EncontrarId = _alienservice.Aliens.Find(idRemovido);

            _alienservice.Aliens.Remove(EncontrarId);
            _alienservice.SaveChangesAsync();
        }
    }
}