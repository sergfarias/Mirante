using AutoMapper;
using Works.DeveloperEvaluation.Application.Tarefas.AlterarTarefa;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.AlterarTarefa;

public class AlterarTarefaProfile : Profile
{
    public AlterarTarefaProfile()
    {
        CreateMap<AlterarTarefaRequest, AlterarTarefaCommand>();
        CreateMap<AlterarTarefaResult, AlterarTarefaResponse>();
    }
}
