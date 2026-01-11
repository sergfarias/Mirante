using Works.DeveloperEvaluation.Domain.Enums;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.RelatorioTarefa;

public class RelatorioTarefaRequest
{
    public Status Status { get; set; }
    public DateTime DtInicio { get; set; }
    public DateTime DtFim { get; set; }
}