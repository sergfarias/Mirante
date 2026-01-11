namespace Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;

public class ListarTarefaResult
{
    public int ID { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int Status { get; set; }
    public DateTime DataVencimento { get; set; }
}
