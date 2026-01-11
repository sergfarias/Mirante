namespace Works.DeveloperEvaluation.Application.Tarefas.AlterarTarefa;

public class AlterarTarefaResult
{
    public int ID { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int Status { get; set; }
    public DateTime DataVencimento { get; set; }
}
