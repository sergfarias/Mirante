using AutoMapper;
using Works.DeveloperEvaluation.Domain.Entities;
using Works.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;
namespace Works.DeveloperEvaluation.Application.Tarefas.AlterarTarefa;

public class AlterarTarefaHandler : IRequestHandler<AlterarTarefaCommand, AlterarTarefaResult>
{
    private readonly ITarefaRepository _TarefaRepository;
    private readonly IMapper _mapper;

    public AlterarTarefaHandler(ITarefaRepository TarefaRepository, IMapper mapper)
    {
        _TarefaRepository = TarefaRepository;
        _mapper = mapper;
    }

    public async Task<AlterarTarefaResult> Handle(AlterarTarefaCommand command, CancellationToken cancellationToken)
    {
        var Tarefa = _mapper.Map<Tarefa>(command);

        var TarefaDB = await _TarefaRepository.GetByIdAsync(Tarefa.ID, cancellationToken);
        if (TarefaDB == null)
        {
            throw new ValidationException("Tarefa de código " + Tarefa.ID + " não encontrado.");
        }
        else
        {
            var alterarTarefa = await _TarefaRepository.UpdateAsync(Tarefa, cancellationToken);
            var result = _mapper.Map<AlterarTarefaResult>(alterarTarefa);
            return result;
        }
    }
}
