using Api_Ben10.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien.Application.Validate
{
    public class CadastroUsuarioValidate : AbstractValidator<AlienUser>
    {
        public CadastroUsuarioValidate()
        {
            RuleFor(custumer => custumer.Email).NotNull().WithMessage("Email não pode ser vazio!").NotEmpty().EmailAddress();
            RuleFor(custumer => custumer.Password).NotNull().WithMessage("Senha não pode ser vazio!").NotEmpty();

            RuleFor(p => p).Must(BeValid);
        }

        private bool BeValid(AlienUser user)
        {
            if (user.Password.Length > 10 && user.Password.Length < 5)
            {
                return false;
            }

            return true;
        }

    }
}
