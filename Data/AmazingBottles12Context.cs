using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmazingBottles12.Models;

namespace AmazingBottles12.Data
{
    public class AmazingBottles12Context : DbContext
    {
        public AmazingBottles12Context (DbContextOptions<AmazingBottles12Context> options)
            : base(options)
        {
        }

        public DbSet<AmazingBottles12.Models.Bottle> Bottle { get; set; }
    }
}
