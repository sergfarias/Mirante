using AutoMapper;
using Works.DeveloperEvaluation.Domain.Entities;
namespace Works.DeveloperEvaluation.Application.Tarefas.BuscarTarefa;

public class BuscarTarefaProfile : Profile
{
    public BuscarTarefaProfile()
    {
        CreateMap<BuscarTarefaCommand, Tarefa>();
        CreateMap<Tarefa, BuscarTarefaResult>();
    }
}
