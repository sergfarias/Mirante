using Works.DeveloperEvaluation.Domain.Entities;
using Works.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Works.DeveloperEvaluation.Domain.Validation;

public class TarefaValidator : AbstractValidator<Tarefa>
{
    public TarefaValidator()
    {

        RuleFor(Tarefa => Tarefa.Titulo)
           .NotEmpty()
           .MaximumLength(40).WithMessage("Título não pode ser maior que 100 caracteres.");

        RuleFor(Tarefa => Tarefa.Descricao)
          .MaximumLength(40).WithMessage("Descrição não pode ser maior que 100 caracteres.");

  }
}
