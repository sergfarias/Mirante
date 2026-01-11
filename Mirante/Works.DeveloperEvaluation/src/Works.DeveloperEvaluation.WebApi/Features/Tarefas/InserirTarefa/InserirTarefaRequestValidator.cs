using FluentValidation;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.InserirTarefa;

public class InserirTarefaRequestValidator : AbstractValidator<InserirTarefaRequest>
{
    public InserirTarefaRequestValidator()
    {
        RuleFor(Tarefa => Tarefa.Titulo)
          .NotEmpty()
          .MaximumLength(40).WithMessage("Título não pode ser maior que 100 caracteres.");

        RuleFor(Tarefa => Tarefa.Descricao)
          .MaximumLength(40).WithMessage("Descrição não pode ser maior que 100 caracteres.");
    }
}