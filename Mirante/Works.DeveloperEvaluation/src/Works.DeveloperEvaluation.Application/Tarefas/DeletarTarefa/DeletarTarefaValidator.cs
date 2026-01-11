using FluentValidation;
namespace Works.DeveloperEvaluation.Application.Tarefas.DeletarTarefa;

public class DeletarTarefaValidator : AbstractValidator<DeletarTarefaCommand>
{
    public DeletarTarefaValidator()
    {
        RuleFor(x => x.ID)
            .NotEmpty()
            .WithMessage("Código do Tarefa é obrigatório.");
    }
}
