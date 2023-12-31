﻿using System.Collections.Generic;
using System.Reflection.Emit;
using APIPROYECTO1.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPROYECTO1.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(

                DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Prenda> Prendas { get; set; }

        public DbSet<Accesorios> Accesorios { get; set; }

        public DbSet<Promocion> promociones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prenda>().HasData(
                 new Prenda()
                 {
                     IdPrenda = 1,
                     Nombre = "prenda1",
                     Descripcion = "Pantalon",
                     Marca = "zara",
                     Cantidad = 2,
                     Precio = 40

                 },
            new Prenda()
            {
                IdPrenda = 2,
                Nombre = "prenda2",
                Descripcion = "falda",
                Marca = "zara",
                Cantidad = 3,
                Precio = 20


            }
            );

            modelBuilder.Entity<Accesorios>().HasData(
                new Accesorios()
                {
                    IdAccesorio = 100,
                    Nombre = "Collar",
                    Descripcion = "Collar blanco de plata",
                    Marca = "cartier",
                    Cantidad = 2,
                    Precio = 11

                },
            new Accesorios()
            {
                IdAccesorio = 101,
                Nombre = "Aretes",
                Descripcion = "Aretes largos",
                Marca = "buccellati",
                Cantidad = 3,
                Precio = 20
            }
            );

            modelBuilder.Entity<Accesorios>().HasData(
                new Accesorios()
                {
                    IdAccesorio = 1,
                    Nombre = "Collar",
                    Descripcion = "Collar blanco de plata",
                    Marca = "cartier",
                    Cantidad = 2,
                    Precio = 11

                },
            new Accesorios()
            {
                IdAccesorio = 2,
                Nombre = "Aretes",
                Descripcion = "Aretes largos",
                Marca = "buccellati",
                Cantidad = 3,
                Precio = 20
            }
            );


            modelBuilder.Entity<Promocion>().HasData(
            new Promocion()
            {
                IdPromocion = 1,
                Nombre = "Promocion 1",
                Descripcion = "Blusa azul",
                Marca = "shein",
                Cantidad = 2,
                Precio = 13

            },
            new Promocion()
            {
                IdPromocion = 2,
                Nombre = "Promocion 2",
                Descripcion = "Aretes largos",
                Marca = "shein",
                Cantidad = 3,
                Precio = 15
            }
            );

        }
    }
}