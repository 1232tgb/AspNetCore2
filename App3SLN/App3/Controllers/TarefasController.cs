using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App3.Controllers
{

    public class TarefasController : Controller
    {
        TarefasContexto context;

        public TarefasController(TarefasContexto context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Tarefas> tarefas = await context.Tarefas.ToListAsync();
            return View(tarefas);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
                return NotFound();

            Tarefas tarefa = await context.Tarefas.FirstOrDefaultAsync(x => x.Id == Id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tarefas tarefa)
        {
            if (ModelState.IsValid)
            {
                await context.Tarefas.AddAsync(tarefa);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(tarefa);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? Id)
        {
            if (Id == null)
                return NotFound();

            Tarefas tarefa = await context.Tarefas.FirstOrDefaultAsync(x => x.Id == Id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Tarefas tarefa)
        {
            if (ModelState.IsValid)
            {
                string Tarefa = $"{tarefa.Id} - {tarefa.Nome}";
                context.Tarefas.Update(tarefa);
                await context.SaveChangesAsync();

                ViewData["Title"] = $"Tarefa atualizada: {Tarefa}";
                return View("ConfirmAction");
            }

            return View(tarefa);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            Tarefas tarefa = await context.Tarefas.FirstOrDefaultAsync(x => x.Id == Id);

            if (tarefa == null)
                return NotFound();


            return View(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Tarefas tarefa)
        {

            context.Tarefas.Remove(tarefa);
            await context.SaveChangesAsync();

            ViewData["Title"] = "Tarefa deletada";
            return View("ConfirmAction");
        }


    }
}