using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MultiLanguageASP.Models
{
    public class MultiLanguageASPContext : DbContext
    {
        public MultiLanguageASPContext (DbContextOptions<MultiLanguageASPContext> options)
            : base(options)
        {
        }

        public DbSet<MultiLanguageASP.Models.Customer> Customer { get; set; }
    }
}
