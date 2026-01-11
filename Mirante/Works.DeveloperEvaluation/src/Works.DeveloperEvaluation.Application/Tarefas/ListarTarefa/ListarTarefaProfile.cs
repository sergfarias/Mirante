using AutoMapper;
using Works.DeveloperEvaluation.Domain.Entities;
namespace Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;

public class ListarTarefaProfile : Profile
{
    public ListarTarefaProfile()
    {
        CreateMap<ListarTarefaCommand, Tarefa>();
        CreateMap<Tarefa, ListarTarefaResult>();
    }
}
