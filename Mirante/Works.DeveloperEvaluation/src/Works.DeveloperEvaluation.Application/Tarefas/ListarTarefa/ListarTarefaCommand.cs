using MediatR;
namespace Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;

/// <summary>
/// Command for list a project.
/// </summary>
public class ListarTarefaCommand : IRequest<List<ListarTarefaResult>>
{
    public int ID { get; set; }

}