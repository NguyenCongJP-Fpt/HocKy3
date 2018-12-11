using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HiMiddleware.Models;

namespace HiMiddleware.Models
{
    public class HiMiddlewareContext : DbContext
    {
        public HiMiddlewareContext (DbContextOptions<HiMiddlewareContext> options)
            : base(options)
        {
        }

        public DbSet<HiMiddleware.Models.Customer> Customer { get; set; }

        public DbSet<HiMiddleware.Models.Credential> Credential { get; set; }
    }
}
