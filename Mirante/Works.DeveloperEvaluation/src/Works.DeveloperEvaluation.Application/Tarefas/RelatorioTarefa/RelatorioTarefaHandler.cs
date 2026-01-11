using AutoMapper;
using MediatR;
using Works.DeveloperEvaluation.Domain.Repositories;
using Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;
namespace Works.DeveloperEvaluation.Application.Tarefas.RelatorioTarefa;

public class RelatorioTarefaHandler : IRequestHandler<RelatorioTarefaCommand, List<RelatorioTarefaResult>>
{
    private readonly ITarefaRepository _TarefaRepository;
    private readonly IMapper _mapper;

    public RelatorioTarefaHandler(
        ITarefaRepository TarefaRepository,
        IMapper mapper)
    {
        _TarefaRepository = TarefaRepository;
        _mapper = mapper;
    }

    public async Task<List<RelatorioTarefaResult>> Handle(RelatorioTarefaCommand command, CancellationToken cancellationToken)
    {
        try {
            var Tarefas = await _TarefaRepository.GetTarefasFiltroAsync(command.Status, command.DtInicio, command.DtFim, cancellationToken);
            return _mapper.Map<List<RelatorioTarefaResult>>(Tarefas);
        }
        catch(Exception)
        {
            return null;
        }
    }
}
