using MediatR;
namespace Works.DeveloperEvaluation.Application.Tarefas.DeletarTarefa;

public record DeletarTarefaCommand : IRequest<DeletarTarefaResponse>
{
    public int ID { get; }

    public DeletarTarefaCommand(int id)
    {
        ID = id;
    }
}
