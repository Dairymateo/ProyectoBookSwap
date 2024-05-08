using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoBookSwap.Models;

namespace ProyectoBookSwap.Data
{
    public class ProyectoBookSwapContext : DbContext
    {
        public ProyectoBookSwapContext (DbContextOptions<ProyectoBookSwapContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoBookSwap.Models.Usuarios> Usuarios { get; set; } = default!;
        public DbSet<ProyectoBookSwap.Models.Libros> Libros { get; set; } = default!;
    }
}
