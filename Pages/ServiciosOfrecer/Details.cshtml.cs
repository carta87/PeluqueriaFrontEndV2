using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_ServiciosOfrecer
{
    public class DetailsModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public DetailsModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

      public ServiciosOfrecer ServiciosOfrecer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ServiciosOfrecer == null)
            {
                return NotFound();
            }

            var serviciosofrecer = await _context.ServiciosOfrecer.FirstOrDefaultAsync(m => m.Id == id);
            if (serviciosofrecer == null)
            {
                return NotFound();
            }
            else
            {
                ServiciosOfrecer = serviciosofrecer;
            }
            return Page();
        }
    }
}
