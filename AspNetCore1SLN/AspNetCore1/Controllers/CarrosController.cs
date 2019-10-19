using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore1.Controllers
{

    public class CarrosController : Controller
    {
        ContextDB context;


        public CarrosController(ContextDB context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Carro> carros = context.Carros.ToList();
            return View(carros);
        }


        [HttpGet]
        public IActionResult NewCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewCar(Carro carro)
        {
            if (ModelState.IsValid)
            {
                context.Carros.Add(carro);
                context.SaveChanges();
                ViewData["Titulo"] = "Car Submited";
                return View("Confirm");
            }
            return View();
        }

        [HttpGet]
        public IActionResult ConfirmSubmit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            Carro carro = context.Carros.Find(id);

            if (carro == null)
                return NotFound();

            return View(carro);
        }
        //Não precisa colocar o id no parametro, mas precisa colocar Route definido abaixo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Carro carro)
        {
            if (ModelState.IsValid)
            {
                context.Carros.Update(carro);
                context.SaveChanges();
                ViewData["Titulo"] = "Car Updated";
                return View("Confirm");
            }
            return View(carro);
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null)
                return NotFound();

            Carro carro = context.Carros.First(i => i.Id == Id);

            if (carro == null)
                return NotFound();

            return View(carro);

        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            Carro carro = context.Carros.First(i => i.Id == Id);

            if (carro == null)
                return NotFound();


            context.Carros.Remove(carro);
            context.SaveChanges();

            ViewData["Titulo"] = "Car Removed";
            return View("Confirm");

        }

        [HttpGet]
        public IActionResult Excluir(int? Id)
        {
            if (Id == null)
                return NotFound();

            Carro carro = context.Carros.First(i => i.Id == Id);

            if (carro == null)
                return NotFound();

            return View(carro);
        }

        [HttpPost]
        public IActionResult Excluir(Carro carro)
        {

            if (carro == null)
                return NotFound();


            context.Carros.Remove(carro);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost, ActionName("Excluir")]
        //public IActionResult ConfirmarExclusao(Carro carro)
        //{

        //    if (carro == null)
        //        return NotFound();


        //    context.Carros.Remove(carro);
        //    context.SaveChanges();

        //    return RedirectToAction(nameof(Index));
        //}

    }
}