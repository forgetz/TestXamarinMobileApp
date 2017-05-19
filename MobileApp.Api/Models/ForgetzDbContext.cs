using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApp.Api.Models
{
    public class ForgetzDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ForgetzDbContext(DbContextOptions<ForgetzDbContext> options) 
            : base(options)
        {

        }

    }
}
