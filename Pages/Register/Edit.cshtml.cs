using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PSA_AB_YM_JS.Data;
using PSA_AB_YM_JS.Model;

namespace PSA_AB_YM_JS.Pages.Register
{
    public class EditModel : PageModel
    {
        private readonly PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext _context;

        public EditModel(PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Traveller Traveller { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Traveller == null)
            {
                return NotFound();
            }

            var traveller =  await _context.Traveller.FirstOrDefaultAsync(m => m.email == id);
            if (traveller == null)
            {
                return NotFound();
            }
            Traveller = traveller;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Traveller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravellerExists(Traveller.email))
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

        private bool TravellerExists(string id)
        {
          return (_context.Traveller?.Any(e => e.email == id)).GetValueOrDefault();
        }
    }
}
