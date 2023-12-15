using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class AlienGetDTO
    {
        public Guid Id { get; set; }
        public string NomeAlien { get; set; }
        public int NumeroDoAlien { get; set; }
        public DateTime HorarioDeCadastro { get; set; }
    }
}