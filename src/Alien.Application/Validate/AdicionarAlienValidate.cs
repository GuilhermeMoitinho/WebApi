using ApiBen10.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien.Application.Validate
{
    public class AdicionarAlienValidate : AbstractValidator<AlienModel>
    {
        public AdicionarAlienValidate()
        {
            RuleFor(custumer => custumer.NomeAlien).NotNull().WithMessage("Nome não pode ser vazio!").NotEmpty();

            RuleFor(custumer => custumer.NumeroDoAlien).NotNull().WithMessage("Idade não pode ser vazia!").NotEmpty();

            RuleFor(p => p).Must(BeValid).WithMessage("Veja se: Seu nome não está inválido ou se sua idade não está inválida!");
        }

        private bool BeValid(AlienModel employee)
        {
            if (employee.NomeAlien.Equals("string"))
            {
                return false;
            }

            if (employee.NumeroDoAlien > 100)
            {
                return false;
            }

            return true;
        }
    }
}
