using Microsoft.AspNetCore.Mvc;
using Works.DeveloperEvaluation.Domain.Enums;
using Works.DeveloperEvaluation.Frontend.Services;

namespace Works.DeveloperEvaluation.Frontend.Controllers
{
    public class RelatorioController: Controller
    {
        readonly ITarefaServices _TarefaService;
        public RelatorioController(ITarefaServices TarefaService)
        {
            _TarefaService = TarefaService;
        }

        // GET: Relatorio
        public async Task<ViewResult> Index(Status Status, DateTime DtInicio, DateTime DtFim)
        {
            try
            {
                var Tarefas = await _TarefaService.Relatorio(Status, DtInicio, DtFim);
                return View(Tarefas);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Erro ao carregar Tarefas: {ex.Message}";
                return View();
            }
        }

    }
}

