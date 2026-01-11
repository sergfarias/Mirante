using Works.DeveloperEvaluation.Frontend.Models;
using Works.DeveloperEvaluation.WebApi.Features.Tarefas.ListarTarefa;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Works.DeveloperEvaluation.Domain.Enums;

namespace Works.DeveloperEvaluation.Frontend.Services
{
    public interface ITarefaServices
    {
        Task<IEnumerable> GetAllAsync();
        Task<ListarTarefaResponse> GetByIdAsync(int id);
        Task<ListarTarefaResponse> CreateAsync(Tarefa Tarefa);
        Task UpdateAsync(int id, Tarefa Tarefa);
        Task DeleteAsync(int id);
        Task<IEnumerable> Relatorio(Status status, DateTime DtInicio, DateTime DtFim);
    }
}
