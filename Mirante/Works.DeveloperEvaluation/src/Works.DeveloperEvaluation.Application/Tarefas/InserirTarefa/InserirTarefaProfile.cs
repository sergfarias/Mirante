using AutoMapper;
using Works.DeveloperEvaluation.Domain.Entities;

namespace Works.DeveloperEvaluation.Application.Tarefas.InserirTarefa;

/// <summary>
/// Profile for mapping between sale entity and CreateProjectResponse
/// </summary>
public class InserirTarefaProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateProject operation
    /// </summary>
    public InserirTarefaProfile()
    {
        CreateMap<InserirTarefaCommand, Tarefa>();
        CreateMap<Tarefa, InserirTarefaResult>();
    }
}
