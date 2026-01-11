using AutoMapper;
using Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;
using Works.DeveloperEvaluation.Application.Tarefas.RelatorioTarefa;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.RelatorioTarefa;

public class RelatorioTarefaProfile : Profile
{
    public RelatorioTarefaProfile()
    {
        CreateMap<RelatorioTarefaResult, RelatorioTarefaResponse>();
        CreateMap<RelatorioTarefaRequest, RelatorioTarefaCommand>();
    }
}
