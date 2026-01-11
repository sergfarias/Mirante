using AutoMapper;
using Works.DeveloperEvaluation.Application.Tarefas.BuscarTarefa;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.BuscarTarefa;

public class BuscarTarefaProfile : Profile
{
    public BuscarTarefaProfile()
    {
        CreateMap<BuscarTarefaResult, BuscarTarefaResponse>();
        CreateMap<BuscarTarefaRequest, BuscarTarefaCommand>();
    }
}
