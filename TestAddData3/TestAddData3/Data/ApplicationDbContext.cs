using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestAddData3.Models;

namespace TestAddData3.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomizeUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TestAddData3.Models.Customer> Customer { get; set; }
    }
}
