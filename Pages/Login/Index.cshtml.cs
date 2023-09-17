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
    public class IndexModel : PageModel
    {
        private readonly PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext _context;

        public IndexModel(PSA_AB_YM_JS.Data.PSA_AB_YM_JSContext context)
        {
            _context = context;
        }

        public IList<Traveller> Traveller { get;set; } = default!;

        [BindProperty(SupportsGet = true)]

        public string? emailVal { get; set; }
        public string? password { get; set; } 

        public async Task OnGetAsync()
        {
            var movies = (IQueryable<Traveller>)_context.Traveller;
           

            if (!String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(emailVal))
            {
                movies = movies.Where(s => s.Password.Contains(password));
                movies = movies.Where(s => s.email.Contains(emailVal));
            }

            if (movies != null)
            {
                Traveller = await movies.ToListAsync();
            }
        }


        /* public async Task OnGetAsync()
         {
             if (_context.Traveller != null)
             {
                 Traveller = await _context.Traveller.ToListAsync();
             }
         }*/
    }
}
