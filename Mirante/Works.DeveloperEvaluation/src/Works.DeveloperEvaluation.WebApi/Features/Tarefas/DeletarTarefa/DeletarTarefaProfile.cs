using AutoMapper;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.DeletarTarefa;

public class DeletarTarefaProfile : Profile
{
    public DeletarTarefaProfile()
    {
        CreateMap<int, Application.Tarefas.DeletarTarefa.DeletarTarefaCommand>()
            .ConstructUsing(id => new Application.Tarefas.DeletarTarefa.DeletarTarefaCommand(id));
    }
}
