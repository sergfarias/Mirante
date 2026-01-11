using Microsoft.EntityFrameworkCore;
using Works.DeveloperEvaluation.Domain.Entities;
using Works.DeveloperEvaluation.Domain.Enums;
using Works.DeveloperEvaluation.Domain.Repositories;
namespace Works.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ITarefaRepository using Entity Framework Core
/// </summary>
public class TarefaRepository : ITarefaRepository
{
    private readonly Context _context;

    /// <summary>
    /// Initializes a new instance of tarefaRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public TarefaRepository(Context context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new Tarefa in the database
    /// </summary>
    /// <param name="user">The Tarefa to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created tarefa</returns>
    public async Task<Tarefa> CreateAsync(Tarefa tarefa, CancellationToken cancellationToken = default)
    {
        await _context.Tarefa.AddAsync(tarefa, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return tarefa;
    }

    /// <summary>
    /// Update a Tarefa in the database
    /// </summary>
    /// <param name="Tarefa">The Tarefa to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update tarefa</returns>
    public async Task<Tarefa> UpdateAsync(Tarefa tarefa, CancellationToken cancellationToken = default)
    {
        _context.Entry(tarefa).State = EntityState.Modified;
        await _context.SaveChangesAsync(cancellationToken);
        return tarefa;
    }

    /// <summary>
    /// Deletes a tarefa from the database
    /// </summary>
    /// <param name="id">The unique identifier of the tarefa to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the tarefa was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var tarefa = await GetByIdAsync(id, cancellationToken);
        if (tarefa == null)
            return false;

        _context.Tarefa.RemoveRange(tarefa);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    /// <summary>
    /// Retrieves a tarefa by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the tarefa</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The tarefa if found, null otherwise</returns>
    public async Task<Tarefa?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _context.Tarefa.AsNoTracking().FirstOrDefaultAsync(o => o.ID == id, cancellationToken);
    }

    public async Task<List<Tarefa>?> GetTarefasAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Tarefa.ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<List<Tarefa>?> GetTarefasFiltroAsync(Status status, DateTime DtInicio, DateTime DtFim, CancellationToken cancellationToken = default)
    {
        return await _context.Tarefa.AsNoTracking().Where(o => o.Status == status && o.DataVencimento >= DtInicio && o.DataVencimento <= DtFim).ToListAsync(cancellationToken: cancellationToken);
    }

}
