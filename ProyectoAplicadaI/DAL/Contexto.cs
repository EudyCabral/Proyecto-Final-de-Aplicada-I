﻿using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoAplicadaI.DAL
{
   public class Contexto : DbContext
    {

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<ActivodeNegocio> activodenegocio { get; set; }
        public DbSet<Recibos> recibos { get; set; }
        public DbSet<ReciboDetalles> Detalles { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<EntradadeActivos> entradadeActivos { get; set; }
        public DbSet<Pagos> cobro { get; set; }

        public Contexto() : base ("ConStr")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
