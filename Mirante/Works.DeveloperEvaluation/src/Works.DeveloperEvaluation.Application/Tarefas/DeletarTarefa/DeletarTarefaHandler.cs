using Works.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Works.DeveloperEvaluation.Application.Tarefas.DeletarTarefa;

public class DeletarTarefaHandler : IRequestHandler<DeletarTarefaCommand, DeletarTarefaResponse>
{
    private readonly ITarefaRepository _TarefaRepository;
    
    public DeletarTarefaHandler(ITarefaRepository TarefaRepository)
    {
        _TarefaRepository = TarefaRepository;
    }

    public async Task<DeletarTarefaResponse> Handle(DeletarTarefaCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeletarTarefaValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var success = await _TarefaRepository.DeleteAsync(request.ID, cancellationToken);
        if (!success)
            throw new KeyNotFoundException($"Tarefa de código {request.ID} não encontrado.");

        return new DeletarTarefaResponse { Success = true };
    }
}
