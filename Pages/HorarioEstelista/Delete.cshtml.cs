using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_HorarioEstelista
{
    public class DeleteModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public DeleteModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        [BindProperty]
      public HorarioEstelista HorarioEstelista { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.HorarioEstelista == null)
            {
                return NotFound();
            }

            var horarioestelista = await _context.HorarioEstelista.FirstOrDefaultAsync(m => m.Id == id);

            if (horarioestelista == null)
            {
                return NotFound();
            }
            else
            {
                HorarioEstelista = horarioestelista;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.HorarioEstelista == null)
            {
                return NotFound();
            }
            var horarioestelista = await _context.HorarioEstelista.FindAsync(id);

            if (horarioestelista != null)
            {
                HorarioEstelista = horarioestelista;
                _context.HorarioEstelista.Remove(HorarioEstelista);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
