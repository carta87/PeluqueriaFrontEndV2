using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_Estelista
{
    public class MenuEstilistaModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public MenuEstilistaModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        public IList<Estelista> Estelista { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Estelista != null)
            {
                Estelista = await _context.Estelista.ToListAsync();
            }
        }
    }
}
