using AutoMapper;
using Works.DeveloperEvaluation.Application.Tarefas.InserirTarefa;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.InserirTarefa;

public class InserirTarefaProfile : Profile
{
    public InserirTarefaProfile()
    {
        CreateMap<InserirTarefaRequest, InserirTarefaCommand>();
        CreateMap<InserirTarefaResult, GetTarefaResponse>();
    }
}
