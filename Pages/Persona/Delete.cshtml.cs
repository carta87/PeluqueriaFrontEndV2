using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_Persona
{
    public class DeleteModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public DeleteModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Persona Persona { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Persona == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona.FirstOrDefaultAsync(m => m.Id == id);

            if (persona == null)
            {
                return NotFound();
            }
            else
            {
                Persona = persona;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Persona == null)
            {
                return NotFound();
            }
            var persona = await _context.Persona.FindAsync(id);

            if (persona != null)
            {
                Persona = persona;
                _context.Persona.Remove(Persona);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
