using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyensVases.Models;

namespace NguyensVases.Data
{
    public class NguyensVasesContext : DbContext
    {
        public NguyensVasesContext (DbContextOptions<NguyensVasesContext> options)
            : base(options)
        {
        }

        public DbSet<NguyensVases.Models.Vases> Vases { get; set; }
    }
}
