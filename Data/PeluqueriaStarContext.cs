using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeluqueiaStar.Models;

    public class PeluqueriaStarContext : DbContext
    {
        public PeluqueriaStarContext (DbContextOptions<PeluqueriaStarContext> options)
            : base(options)
        {
        }

        public DbSet<PeluqueiaStar.Models.Administrador> Administrador { get; set; } = default!;

        public DbSet<PeluqueiaStar.Models.Cliente>? Cliente { get; set; }

        public DbSet<PeluqueiaStar.Models.Estelista>? Estelista { get; set; }

        public DbSet<PeluqueiaStar.Models.HorarioEstelista>? HorarioEstelista { get; set; }

        public DbSet<PeluqueiaStar.Models.Persona>? Persona { get; set; }

        public DbSet<PeluqueiaStar.Models.ServiciosOfrecer>? ServiciosOfrecer { get; set; }
    }
