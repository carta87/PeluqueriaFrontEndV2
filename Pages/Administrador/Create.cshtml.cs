using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeluqueiaStar.Models;

namespace PeluqueiaStar.Pages_Administrador
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
        public Administrador Administrador { get; set; } = default!;
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Administrador == null || Administrador == null)
            {
                return Page();
            }

            _context.Administrador.Add(Administrador);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
