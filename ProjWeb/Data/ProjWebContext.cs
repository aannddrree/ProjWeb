using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjWeb.Models;

namespace ProjWeb.Data
{
    public class ProjWebContext : DbContext
    {
        public ProjWebContext (DbContextOptions<ProjWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjWeb.Models.Grafico> Grafico { get; set; }
    }
}
