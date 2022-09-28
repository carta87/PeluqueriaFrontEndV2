using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_HorarioEstelista
{
    public class CreateModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public CreateModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HorarioEstelista HorarioEstelista { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.HorarioEstelista == null || HorarioEstelista == null)
            {
                return Page();
            }

            _context.HorarioEstelista.Add(HorarioEstelista);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
