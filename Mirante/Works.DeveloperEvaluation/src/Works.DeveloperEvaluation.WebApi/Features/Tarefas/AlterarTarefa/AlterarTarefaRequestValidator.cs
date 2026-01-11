using FluentValidation;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.AlterarTarefa;

public class AlterarTarefaRequestValidator : AbstractValidator<AlterarTarefaRequest>
{
    public AlterarTarefaRequestValidator()
    {
        RuleFor(Tarefa => Tarefa.ID)
           .NotEmpty()
           .WithMessage("Código do Tarefa é obrigatório");

        RuleFor(Tarefa => Tarefa.Titulo)
          .NotEmpty()
          .MaximumLength(40).WithMessage("Título não pode ser maior que 100 caracteres.");

        RuleFor(Tarefa => Tarefa.Descricao)
          .MaximumLength(40).WithMessage("Descrição não pode ser maior que 100 caracteres.");
    }
}