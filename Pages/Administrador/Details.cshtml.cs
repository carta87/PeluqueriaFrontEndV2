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
    public class DetailsModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public DetailsModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

      public Administrador Administrador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Administrador == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador.FirstOrDefaultAsync(m => m.Id == id);
            if (administrador == null)
            {
                return NotFound();
            }
            else {
                Administrador = administrador;
            }
            return Page();
        }
    }
}
