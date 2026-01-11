using AutoMapper;
using MediatR;
using Works.DeveloperEvaluation.Domain.Repositories;
namespace Works.DeveloperEvaluation.Application.Tarefas.BuscarTarefa;

public class BuscarTarefaHandler : IRequestHandler<BuscarTarefaCommand, BuscarTarefaResult>
{
    private readonly ITarefaRepository _TarefaRepository;
    private readonly IMapper _mapper;

    public BuscarTarefaHandler(
        ITarefaRepository TarefaRepository,
        IMapper mapper)
    {
        _TarefaRepository = TarefaRepository;
        _mapper = mapper;
    }

    public async Task<BuscarTarefaResult> Handle(BuscarTarefaCommand command, CancellationToken cancellationToken)
    {
        var Tarefas = await _TarefaRepository.GetByIdAsync(command.ID);
        return _mapper.Map<BuscarTarefaResult>(Tarefas);
    }
}
