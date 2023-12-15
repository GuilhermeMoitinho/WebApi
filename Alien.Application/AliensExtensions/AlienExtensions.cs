using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBen10.Domain.Entities;
using Application.DTO;

namespace Application.AliensExtensions
{
    public static class AlienExtensions
    {
        public static Alien ParaAlienDomainDTO(this AlienPostDTO alienpostdto)
        {
            return new Alien
            {
                HorarioDeCadastro = DateTime.Now,
                NomeAlien = alienpostdto.NomeAlien,
                NumeroDoAlien = alienpostdto.NumeroDoAlien
            };
        }

        public static AlienGetDTO ParaAlienGetDTO(this Alien alien)
        {
            return new AlienGetDTO
            {
                HorarioDeCadastro = alien.HorarioDeCadastro,
                NomeAlien = alien.NomeAlien,
                NumeroDoAlien = alien.NumeroDoAlien,
                Id = alien.Id
            };
        }

        public static IEnumerable<AlienGetDTO> ParaAliensGetDto(this IEnumerable<Alien> aliens)
        {
            return aliens.Select(alien => alien.ParaAlienGetDTO()).ToList();
        }

    }
}