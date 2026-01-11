using MediatR;
namespace Works.DeveloperEvaluation.Application.Tarefas.InserirTarefa;

public class InserirTarefaCommand : IRequest<InserirTarefaResult>
{
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int Status { get; set; }
    public DateTime DataVencimento { get; set; }
}