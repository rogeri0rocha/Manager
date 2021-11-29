using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Domain.Entities;
using FluentValidation;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")

                .NotNull()
                .WithMessage("Não pode ser nulo");

            RuleFor(x => x.Email)
                 .NotEmpty()
                .WithMessage("O email não pode ser vazio")

                .NotNull()
                .WithMessage("Não pode ser nulo")

                .MinimumLength(10)
                .WithMessage("O tamanho minimo do email é 10 caracteres")

                .MaximumLength(80)
                .WithMessage("O tamanho máximo do email é 10 caracteres")

                .Matches(@"/ ^[a - z0 - 9.] +@[a - z0 - 9] +\.[a-z]+\.([a - z] +) ?$/ i;")
                .WithMessage("O Email informado não é valido");
                

            RuleFor(x => x.Name)
                  .NotEmpty()
                .WithMessage("O nome não pode ser vazio")

                .NotNull()
                .WithMessage("Não pode ser nulo");

            RuleFor(x => x.Password)
                  .NotEmpty()
                .WithMessage("A senha não pode ser vazio")

                .NotNull()
                .WithMessage("Não pode ser nulo");

        }

    }
}
