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
    public class DetailsMesswert : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public DetailsMesswert(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        public Messwert Messwert { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messwert = await _context.Messwert.FirstOrDefaultAsync(m => m.Id == id);
            if (messwert == null)
            {
                return NotFound();
            }
            else
            {
                Messwert = messwert;
            }
            return Page();
        }
    }
}