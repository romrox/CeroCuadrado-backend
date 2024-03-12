using Microsoft.EntityFrameworkCore;
using CeroCuadrado.Entities;
using ProyectoCeroCuadrado.Entities;
using System.Runtime.InteropServices;






namespace CeroCuadrado.Data
{
    public class PresupuestoContext : DbContext

    {
        public DbSet<CentroDeCostos> CentroDeCostos { get; set; }
        public DbSet<Certificados> Certificados { get; set;}

        public DbSet<Egresos> Egresos  { get; set; }
        public DbSet<Empresas> Empresas { get; set;}
        public DbSet<FormaDePago> FormaDePago { get; set;}
        public DbSet<Impuestos> Impuestos { get; set;}


        public DbSet<Ingresos> Ingresos { get; set;}
        public DbSet<Insumos> Insumos { get; set;}
        public DbSet<PlanDeCuentas> PlanDeCuentas { get;set;}
        public DbSet<Porcentajes> Porcentajes { get; set;}
        public DbSet<Presupuesto> Presupuestos { get; set;}
        public DbSet<Proveedores> Proveedores { get; set;}
        public DbSet<Rubros> Rubros { get; set;}
        public DbSet<SubRubros> SubRubros { get; set;}
        public DbSet<Tareas> Tareas { get; set;}
        public DbSet<TipoDeComprobante> TipoDeComprobantes { get; set;}
        public DbSet<TipoDeCosto> TipoDeCosto { get;set;}
        public DbSet<TipoDeOperaciones> TipoDeOperaciones { get; set;}
        public DbSet<Unidades> Unidades { get; set;}

        public PresupuestoContext(DbContextOptions<PresupuestoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Insumos>()
            .HasOne(i => i.Unidades)
            .WithMany(u => u.Insumos)
            .HasForeignKey(i => i.UnidadesId);

            modelBuilder.Entity<Tareas>()
            .HasOne(i => i.Unidades)
            .WithMany(u => u.Tareas)
            .HasForeignKey(i => i.UnidadesId);




        }
 
    }
}
