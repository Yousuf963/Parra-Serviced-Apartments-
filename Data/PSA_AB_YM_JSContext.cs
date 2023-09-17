using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PSA_AB_YM_JS.Model;

namespace PSA_AB_YM_JS.Data
{
    public class PSA_AB_YM_JSContext : DbContext
    {
        public PSA_AB_YM_JSContext (DbContextOptions<PSA_AB_YM_JSContext> options)
            : base(options)
        {
        }

        public DbSet<PSA_AB_YM_JS.Model.Traveller> Traveller { get; set; } = default!;
    }
}
