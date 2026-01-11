namespace Works.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a Tarefa in the system.
/// </summary>
public class TarefaDetalhesView //: ITarefa //BaseEntity,
{
    public int? CodL { get; set; }
    public string? Titulo { get; set; } = string.Empty;
    public string? Editora { get; set; } = string.Empty;
    public int? Edicao { get; set; }
    public string? AnoPublicacao { get; set; } = string.Empty;
    public string? Assunto { get; set; } = string.Empty;
    public string? Autor { get; set; } = string.Empty;
}