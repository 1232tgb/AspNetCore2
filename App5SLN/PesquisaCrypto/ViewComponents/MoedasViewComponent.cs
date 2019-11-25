using Microsoft.AspNetCore.Mvc;
using PesquisaCrypto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedasContext _contexto;

        public MoedasViewComponent(MoedasContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
