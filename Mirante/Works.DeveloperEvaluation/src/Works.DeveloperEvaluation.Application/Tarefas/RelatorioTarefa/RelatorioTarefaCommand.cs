using MediatR;
using Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;
using Works.DeveloperEvaluation.Domain.Enums;
namespace Works.DeveloperEvaluation.Application.Tarefas.RelatorioTarefa;

public class RelatorioTarefaCommand : IRequest<List<RelatorioTarefaResult>>
{
    public Status Status { get; set; }
    public DateTime DtInicio { get; set; }
    public DateTime DtFim { get; set; }
}