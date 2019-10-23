using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App3.Models;
using Microsoft.AspNetCore.Mvc;


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
        public IActionResult Index()
        {
            IEnumerable<Tarefas> tarefas = context.Tarefas.ToList();
            return View(tarefas);
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null)
                return NotFound();

            Tarefas tarefa = context.Tarefas.FirstOrDefault(x => x.Id == Id);

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
        public IActionResult Create(Tarefas tarefa)
        {
            if (ModelState.IsValid)
            {
                context.Tarefas.Add(tarefa);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(tarefa);
        }

        [HttpGet]
        public IActionResult Update(int? Id)
        {
            if (Id == null)
                return NotFound();

            Tarefas tarefa = context.Tarefas.FirstOrDefault(x => x.Id == Id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Update(Tarefas tarefa)
        {
            if (ModelState.IsValid)
            {
                string Tarefa = $"{tarefa.Id} - {tarefa.Nome}";
                context.Tarefas.Update(tarefa);
                context.SaveChanges();

                ViewData["Title"] = $"Tarefa atualizada: {Tarefa}";
                return View("ConfirmAction");
            }

            return View(tarefa);
        }


        //public IActionResult Delete(int? Id)
        //{
        //    if (Id == null)
        //        return NotFound();

        //    Tarefas tarefa = context.Tarefas.FirstOrDefault(x => x.Id == Id);

        //    if (tarefa == null)
        //        return NotFound();


        //    return View(tarefa);
        //}

        //public IActionResult Delete(Tarefas tarefa)
        //{

        //    context.Tarefas.Remove(tarefa);
        //    context.SaveChanges();

        //    return View("ConfirmAction");
        //}


    }
}