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
    public class IndexMesswert : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public IndexMesswert(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        public IList<Messwert> Messwerte { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Messwerte = await _context.Messwert
                .Include(m => m.Messstation).ToListAsync();
        }
    }
}
