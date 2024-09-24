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
    public class DeleteModel : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public DeleteModel(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Messstation Messstation { get; set; } = default!;

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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messstation = await _context.Messstation.FindAsync(id);
            if (messstation != null)
            {
                Messstation = messstation;
                _context.Messstation.Remove(Messstation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
