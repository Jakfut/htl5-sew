using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _02_Messstation.Data;
using _02_Messstation.Models;

namespace _02_Messstation
{
    public class EditModel : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public EditModel(_02_Messstation.Data.MessstationContext context)
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

            var messstation =  await _context.Messstation.FirstOrDefaultAsync(m => m.Id == id);
            if (messstation == null)
            {
                return NotFound();
            }
            Messstation = messstation;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Messstation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessstationExists(Messstation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MessstationExists(int id)
        {
            return _context.Messstation.Any(e => e.Id == id);
        }
    }
}
