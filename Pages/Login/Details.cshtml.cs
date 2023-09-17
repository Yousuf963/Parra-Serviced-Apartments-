using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PSA_AB_YM_JS.Data;
using PSA_AB_YM_JS.Model;

namespace PSA_AB_YM_JS.Pages.Login
{
    public class DetailsModel : PageModel
    {
        private readonly PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext _context;

        public DetailsModel(PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext context)
        {
            _context = context;
        }

      public Traveller Traveller { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Traveller == null)
            {
                return NotFound();
            }

            var traveller = await _context.Traveller.FirstOrDefaultAsync(m => m.email == id);
            if (traveller == null)
            {
                return NotFound();
            }
            else 
            {
                Traveller = traveller;
            }
            return Page();
        }
    }
}
