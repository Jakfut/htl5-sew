using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _02_Messstation.Data;
using _02_Messstation.Models;

namespace _02_Messstation
{
    public class DetailsModel : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public DetailsModel(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        public Messstation Messstation { get; set; } = default!;
        
        public List<Messwert> Messwerte { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messstation = await _context.Messstation.FirstOrDefaultAsync(m => m.Id == id);
            if (messstation == null)
            {
                return NotFound();
            }
            else
            {
                Messstation = messstation;
            }
            List<Messwert> messwerte = await _context.Messwert.Where(m => m.MessstationId == id).ToListAsync();
            
            Messwerte = messwerte;
            
            return Page();
        }
    }
}
