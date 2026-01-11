using AutoMapper;
using MediatR;
using Works.DeveloperEvaluation.Domain.Repositories;
using Works.DeveloperEvaluation.Domain.Entities;
namespace Works.DeveloperEvaluation.Application.Tarefas.InserirTarefa;

/// <summary>
/// Handler for processing CreateSaleCommand requests
/// </summary>
public class InserirTarefaHandler : IRequestHandler<InserirTarefaCommand, InserirTarefaResult>
{
    private readonly ITarefaRepository _TarefaRepository;
    //private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
  
    /// <summary>
    /// Initializes a new instance of CreateProjectHandler
    /// </summary>
    public InserirTarefaHandler(ITarefaRepository TarefaRepository, IMapper mapper)
    {
        _TarefaRepository = TarefaRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateProjectCommand request
    /// </summary>
    public async Task<InserirTarefaResult> Handle(InserirTarefaCommand command, CancellationToken cancellationToken)
    {
        var Tarefa = _mapper.Map<Tarefa>(command);
        //Tarefa.Id = ;

        //_ = await _userRepository.GetByIdAsync(project.UserId, cancellationToken) ?? throw new KeyNotFoundException("Usuário (" + project.UserId + ") do projeto não encontrado.");
        
        //if (project?.Tasks?.Count > 20)
        //{
        //    throw new InvalidOperationException("Projeto não pode ter mais e 20 tarefas.");
        //}

        //foreach (var item in project.Tasks)
        //{
        //    item.ProjectId = project.Id;
        //    item.CreatedAt = DateTime.Now;
        //    item.Status = Domain.Enums.TaskStatus.Pending;
        //}
        //project.Status = Domain.Enums.ProjectStatus.Active;
        //project.CreatedAt = DateTime.Now;

        var inserirTarefa = await _TarefaRepository.CreateAsync(Tarefa, cancellationToken);
        var result = _mapper.Map<InserirTarefaResult>(inserirTarefa);
        return result;
    }
}
