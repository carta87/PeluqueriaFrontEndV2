using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_Administrador
{
    public class MenuAdministradorModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public MenuAdministradorModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        public IList<Administrador> Administrador { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Administrador != null)
            {
                Administrador = await _context.Administrador.ToListAsync();
            }
        }
    }
}
