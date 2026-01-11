using MediatR;
namespace Works.DeveloperEvaluation.Application.Tarefas.BuscarTarefa;

public class BuscarTarefaCommand : IRequest<BuscarTarefaResult>
{
    public int ID { get; set; }

}