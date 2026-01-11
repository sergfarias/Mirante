using AutoMapper;
using Works.DeveloperEvaluation.Domain.Entities;

namespace Works.DeveloperEvaluation.Application.Tarefas.AlterarTarefa;

public class AlterarTarefaProfile : Profile
{
    public AlterarTarefaProfile()
    {
        CreateMap<AlterarTarefaCommand, Tarefa>();
        CreateMap<Tarefa, AlterarTarefaResult>();
    }
}
