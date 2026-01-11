using AutoMapper;
using Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.ListarTarefa;

public class ListarTarefaProfile : Profile
{
    public ListarTarefaProfile()
    {
        CreateMap<ListarTarefaResult, ListarTarefaResponse>();
        CreateMap<ListarTarefaRequest, ListarTarefaCommand>();
    }
}
