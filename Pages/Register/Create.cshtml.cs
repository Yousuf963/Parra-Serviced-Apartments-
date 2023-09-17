using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PSA_AB_YM_JS.Data;
using PSA_AB_YM_JS.Model;

namespace PSA_AB_YM_JS.Pages.Register
{
    public class CreateModel : PageModel
    {
        private readonly PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext _context;

        public CreateModel(PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Traveller Traveller { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Traveller == null || Traveller == null)
            {
                return Page();
            }

            _context.Traveller.Add(Traveller);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
