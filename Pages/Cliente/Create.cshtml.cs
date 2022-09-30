using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeluqueiaStar.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace PeluqueiaStar.Pages_Cliente
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
        public Cliente Cliente { get; set; } = default!;
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Cliente == null || Cliente == null)
            {
                return Page();
            }

            _context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
