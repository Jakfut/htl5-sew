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
    public class IndexModel : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public IndexModel(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        public IList<Messstation> Messstation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Messstation = await _context.Messstation.ToListAsync();
        }
    }
}
