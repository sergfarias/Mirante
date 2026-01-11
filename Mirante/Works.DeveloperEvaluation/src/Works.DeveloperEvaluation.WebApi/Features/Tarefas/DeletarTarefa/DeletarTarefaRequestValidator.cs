using FluentValidation;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.DeletarTarefa;

public class DeletarTarefaRequestValidator : AbstractValidator<DeletarTarefaRequest>
{
    public DeletarTarefaRequestValidator()
    {
        RuleFor(x => x.ID)
            .NotEmpty()
            .WithMessage("Tarefa ID is required");
    }
}
