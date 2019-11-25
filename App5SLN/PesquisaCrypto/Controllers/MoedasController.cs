using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PesquisaCrypto.Models;

namespace PesquisaCrypto.Controllers
{
    public class MoedasController : Controller
    {


        private MoedasContext _context;


        public MoedasController(MoedasContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Moedas> moedas = await _context.Moedas.ToListAsync();
            return View(moedas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Nome")] Moedas moeda)
        {
            if (ModelState.IsValid)
            {
                await _context.Moedas.AddAsync(moeda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public async Task<IActionResult> EscolhaMoedas(List<Moedas> moedas)
        {
            foreach (Moedas m in moedas)
            {
                if (m.CheckBoxMarcado)
                {
                    Moedas moeda = await _context.Moedas.FirstAsync(x => x.ID == m.ID);
                    moeda.Quantidade += 1;
                    _context.Moedas.Update(moeda);
                    await _context.SaveChangesAsync();

                }
            }
            return RedirectToAction(nameof(Index));
        }

        public JsonResult DadosGrafico()
        {
            var json = _context.Moedas.Select(x => new { x.Nome, x.Quantidade });
            return Json(json);
        }


    }




}