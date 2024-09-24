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
    public class EditMesswert : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public EditMesswert(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Messwert Messwert { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messwert =  await _context.Messwert.FirstOrDefaultAsync(m => m.Id == id);
            if (messwert == null)
            {
                return NotFound();
            }
            Messwert = messwert;
           ViewData["MessstationId"] = new SelectList(_context.Messstation, "Id", "Id");
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

            _context.Attach(Messwert).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MesswertExists(Messwert.Id))
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

        private bool MesswertExists(int id)
        {
            return _context.Messwert.Any(e => e.Id == id);
        }
    }
}
