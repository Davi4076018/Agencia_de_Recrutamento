
using Agencia_de_Recrutamento.Domain.Entities;
using FluentValidation;

namespace Agencia_de_Recrutamento.Service.Validators
{
    public class RecrutadorValidator : AbstractValidator<Recrutador>
    {
        public RecrutadorValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Por favor informe o login.")
                .NotNull().WithMessage("Por favor informe o login.");

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .NotNull().WithMessage("Por favor informe a senha.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");

        }
    }
}
