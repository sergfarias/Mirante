using Works.DeveloperEvaluation.Domain.Enums;

namespace Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;

public class RelatorioTarefaResult
{
    public int? ID { get; set; }
    public string? Titulo { get; set; } = string.Empty;
    public string? Descricao { get; set; } = string.Empty;
    public Status Status { get; set; }
    public DateTime DataVencimento { get; set; } 
}
