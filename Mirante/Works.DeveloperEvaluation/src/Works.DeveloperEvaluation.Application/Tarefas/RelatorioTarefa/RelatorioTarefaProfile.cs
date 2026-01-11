using AutoMapper;
using Works.DeveloperEvaluation.Application.Tarefas.ListarTarefa;
using Works.DeveloperEvaluation.Domain.Entities;
namespace Works.DeveloperEvaluation.Application.Tarefas.RelatorioTarefa;

public class RelatorioTarefaProfile : Profile
{
    public RelatorioTarefaProfile()
    {
        //CreateMap<RelatorioTarefaCommand, TarefaDetalhesView>();
        CreateMap<Tarefa, RelatorioTarefaResult>();
    }
}
