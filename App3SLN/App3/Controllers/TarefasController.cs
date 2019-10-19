using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App3.Models;
using Microsoft.AspNetCore.Mvc;


namespace App3.Controllers
{
    [Route("[controller]")]
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
        [Route("{Id}")]
        public IActionResult Tarefa(int? Id)
        {
            if (Id == null)
                return NotFound();

            Tarefas tarefa = context.Tarefas.FirstOrDefault(x => x.Id == Id);

            if(tarefa == null)
                return NotFound();


            return View(tarefa);

        }
        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //Continuar a partir daqui com o post, depois o delete e o update

    }
}