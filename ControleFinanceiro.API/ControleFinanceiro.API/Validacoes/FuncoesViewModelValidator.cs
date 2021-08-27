using ControleFinanceiro.API.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Validacoes
{
    public class FuncoesViewModelValidator : AbstractValidator<FuncoesViewModel>
    {
        public FuncoesViewModelValidator()
        {
            RuleFor(F => F.Name)
                .NotNull().WithMessage("Preencha a função")
                .NotEmpty().WithMessage("Preencha a Função")
                .MinimumLength(1).WithMessage("Use mais caracteres")
                .MaximumLength(30).WithMessage("Use mais caracteres");

            RuleFor(F => F.Descricao)
                .NotNull().WithMessage("Preencha a descrição")
                .NotEmpty().WithMessage("Preencha a descrição")
                .MinimumLength(1).WithMessage("Use mais caracteres")
                .MaximumLength(50).WithMessage("Use mais caracteres");
        }
    }
}
