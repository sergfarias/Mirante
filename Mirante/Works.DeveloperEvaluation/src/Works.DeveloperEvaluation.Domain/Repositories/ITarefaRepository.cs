using Works.DeveloperEvaluation.Domain.Entities;
using Works.DeveloperEvaluation.Domain.Enums;

namespace Works.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for tarefa entity operations
/// </summary>
public interface ITarefaRepository
{
    /// <summary>
    /// Creates a new tarefa in the repository
    /// </summary>
    /// <param name="user">The tarefa to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created tarefa</returns>
    Task<Tarefa> CreateAsync(Tarefa Tarefa, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a tarefa in the repository
    /// </summary>
    /// <param name="user">The tarefa to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update tarefa</returns>
    Task<Tarefa> UpdateAsync(Tarefa Tarefa, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a tarefa from the database
    /// </summary>
    /// <param name="id">The unique identifier of the tarefa to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the tarefa was deleted, false if not found</returns>
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a tarefa by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the tarefa</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The tarefa if found, null otherwise</returns>
    Task<Tarefa?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<List<Tarefa>?> GetTarefasAsync(CancellationToken cancellationToken = default);

    Task<List<Tarefa>?> GetTarefasFiltroAsync(Status Status, DateTime DtInicio, DateTime DtFim, CancellationToken cancellationToken = default);

}
