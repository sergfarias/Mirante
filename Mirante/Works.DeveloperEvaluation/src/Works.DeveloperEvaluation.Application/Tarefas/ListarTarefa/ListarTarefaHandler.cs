using AutoMapper;
using MediatR;
using Works.DeveloperEvaluation.Domain.Repositories;
using Works.DeveloperEvaluation.Domain.Entities;
namespace Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;

/// <summary>
/// Handler for processing GetProjectCommand requests
/// </summary>
public class ListarTarefaHandler: IRequestHandler<ListarTarefaCommand, List<ListarTarefaResult>>
{
    private readonly ITarefaRepository _TarefaRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ListProjectHandler
    /// </summary>
    public ListarTarefaHandler(
        ITarefaRepository TarefaRepository,
        IMapper mapper)
    {
        _TarefaRepository = TarefaRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ListProjectCommand request
    /// </summary>
    public async Task<List<ListarTarefaResult>> Handle(ListarTarefaCommand command, CancellationToken cancellationToken)
    {
        var Tarefas = new List<Tarefa>();

        if (command.ID == 0)
        {
            var projects = await _TarefaRepository.GetTarefasAsync(cancellationToken);
            if (projects == null)
                throw new KeyNotFoundException($"Projects not found");
            else
                Tarefas.AddRange(projects);
        }
        else
        {
            var projects = await _TarefaRepository.GetByIdAsync(command.ID);
            Tarefas.Add(projects);
        }


        return _mapper.Map<List<ListarTarefaResult>>(Tarefas);
    }
}
