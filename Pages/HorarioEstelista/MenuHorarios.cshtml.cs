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
    public class MenuHorariosModel : PageModel
    {
        private readonly PeluqueriaStarContext _context;

        public MenuHorariosModel(PeluqueriaStarContext context)
        {
            _context = context;
        }

        public IList<HorarioEstelista> HorarioEstelista { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.HorarioEstelista != null)
            {
                HorarioEstelista = await _context.HorarioEstelista.ToListAsync();
            }
        }
    }
}
