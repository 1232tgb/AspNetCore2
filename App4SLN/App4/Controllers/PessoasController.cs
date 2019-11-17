using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App4.Models;
using Microsoft.EntityFrameworkCore;

namespace App4.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoasContext _context;

        public PessoasController(PessoasContext context)
        {
            _context = context;
        }

        //Pega geral
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoas.ToListAsync());
        }

        //Pega 1 baseado na 'Id'
        //Fazer a view
        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> Details(int? Id)
        {
            Pessoa p = await _context.Pessoas.FirstOrDefaultAsync(i => i.Id == Id);
            return View(p);
        }

        //Criar
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Verifica se o post foi valido, se sim, adiciona no BD
        [HttpPost]
        public async Task<IActionResult> Create(Pessoa p)
        {
            if (ModelState.IsValid)
            {
                await _context.Pessoas.AddAsync(p);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? Id)
        {
            if (!IDExists(Id))
            {
                return NotFound();
            }

            Pessoa p = await _context.Pessoas.FirstOrDefaultAsync(i => i.Id == Id);
            return View(p);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Pessoa p)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Pessoas.Update(p);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    return NotFound();
                }

            }

            return View(p);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? Id)
        {
            if (!IDExists(Id))
            {
                return NotFound();
            }

            Pessoa p = await _context.Pessoas.FirstOrDefaultAsync(i => i.Id == Id);

            return View(p);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Pessoa p)
        {
            _context.Pessoas.Remove(p);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        /// <summary>
        /// Checa se Id é nulo e, caso não for, checa se existe algum item no BD com tal Id.
        /// </summary>
        /// <param name="Id">Id do Item no BD</param>
        /// <returns>Um boolean baseado em Id é nulo e, caso não for, checa se existe algum item no BD com tal Id</returns>
        bool IDExists(int? Id)
        {

            if (Id == null)
            {
                return false;
            }

            if (!_context.Pessoas.Any(i => i.Id == Id))
            {
                return false;
            }

            return true;
        }
    }

}