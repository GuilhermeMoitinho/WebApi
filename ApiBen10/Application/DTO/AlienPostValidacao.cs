using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ApiBen10.Application.DTO
{
    public class AlienPostValidacao : AbstractValidator<AlienPostDTO>
    {
        public AlienPostValidacao()
        {
        RuleFor(alien => alien.NumeroDoAlien)
            .GreaterThan(0)
            .WithMessage("O numero deve ser maior que zero");

        RuleFor(alien => alien.NomeAlien)
            .NotEmpty()
            .WithMessage("O nome é obrigatório")
            .MinimumLength(3).WithMessage("O nome do alien de conter pelo menos 3 caractreres")
            .MaximumLength(200).WithMessage("O nome do alien de conter no máximo 100 caractreres");
        }
    }
}