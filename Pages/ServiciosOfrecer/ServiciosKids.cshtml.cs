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
    public class ServiciosKidsModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public ServiciosKidsModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        public IList<ServiciosOfrecer> ServiciosOfrecer { get;set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.ServiciosOfrecer != null)
            {
                ServiciosOfrecer = await _context.ServiciosOfrecer.ToListAsync();
            }
        }   
    }
}
