using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    internal class ApplicatiionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=Fruta; Username=postgres; Password=nada12")
                .EnableSensitiveDataLogging(true);
        }

        public DbSet<Empleadoss> Empleados { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Inventarios> Inventarios { get; set; }

    }
}
