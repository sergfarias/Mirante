using Works.DeveloperEvaluation.Domain.Enums;
namespace Works.DeveloperEvaluation.WebApi.Features.Tarefas.AlterarTarefa;

public class AlterarTarefaResponse
{
    public int ID { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Status Status { get; set; }
    public DateTime DataVencimento { get; set; }

}
