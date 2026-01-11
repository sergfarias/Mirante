using Works.DeveloperEvaluation.Frontend.Services;
using Microsoft.AspNetCore.Mvc;
using Tarefa = Works.DeveloperEvaluation.Frontend.Models.Tarefa;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Works.DeveloperEvaluation.Domain.Enums;

namespace Works.DeveloperEvaluation.Frontend.Controllers
{
    public class TarefasController: Controller
    {
        readonly ITarefaServices _TarefaService;
      
        public TarefasController(ITarefaServices TarefaService)
        {
            _TarefaService = TarefaService;
        }

        // GET: Tarefas
        public async Task<ViewResult> Index()
        {
            try
            {
                var Tarefas = await _TarefaService.GetAllAsync();
                return View(Tarefas);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Erro ao carregar Tarefas: {ex.Message}";
                return View();
            }
        }

        // GET: Produtos/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var produto = await _TarefaService.GetByIdAsync(id);
                return View(produto);
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: Tarefas/Create
        public async Task<ActionResult> Create()
        {
            //ViewBag.Autores = await _autorService.GetAllAsync();
            //ViewBag.Assuntos = await _assuntoService.GetAllAsync();
            return View();
        }

        // POST: Tarefas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Tarefa Tarefa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _TarefaService.CreateAsync(Tarefa);
                    //ViewBag.Autores = await _autorService.GetAllAsync();
                    //ViewBag.Assuntos = await _assuntoService.GetAllAsync();
                    TempData["Success"] = "Tarefa criado com sucesso!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Erro ao criar Tarefa: {ex.Message}");
                }
            }
            return View(Tarefa);
        }

        // GET: Tarefas/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var produto = await _TarefaService.GetByIdAsync(id);
                return View(produto);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Tarefa Tarefa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _TarefaService.UpdateAsync(id, Tarefa);
                    TempData["Success"] = "Tarefa atualizado com sucesso!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Erro ao atualizar produto: {ex.Message}");
                }
            }
            return View(Tarefa);
        }

        // GET: Tarefas/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _TarefaService.DeleteAsync(id);
                TempData["Success"] = "Tarefa atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Erro ao deletar Tarefa: {ex.Message}");
                return RedirectToAction(nameof(Index));
            }
            
        }

        // POST: Tarefas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<RedirectToActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _TarefaService.DeleteAsync(id);
                TempData["Success"] = "Produto excluído com sucesso!";
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Erro ao excluir produto: {ex.Message}";
            }
            return RedirectToAction(nameof(Index));
        }


        // GET: Relatorio
        //public async Task<ViewResult> Relatorio(Status Status, DateTime DtInicio, DateTime DtFim)
        //{
        //    try
        //    {
        //        var Tarefas = await _TarefaService.Relatorio(Status, DtInicio, DtFim);
        //        return View(Tarefas);
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["Error"] = $"Erro ao carregar Tarefas: {ex.Message}";
        //        return View();
        //    }
        //}


    }
}

