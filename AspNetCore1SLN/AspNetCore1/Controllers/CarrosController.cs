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
                return RedirectToAction(nameof(ConfirmSubmit));
            }

            return View();
        }

        [HttpGet]
        public IActionResult ConfirmSubmit()
        {
            return View();
        }



        [HttpGet]
        [Route("{id}")]
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
        [Route("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Carro carro)
        {

            if (ModelState.IsValid)
            {
                context.Carros.Update(carro);
                context.SaveChanges();
                return RedirectToAction(nameof(ConfirmSubmit));
            }

            return View(carro);
        }

        //fazer o delete
    }
}