using CeroCuadrado.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class Presupuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public DateTime? Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }



        //        public CentroDeCostos? CentroDeCostos { get; set; }
        //        public Certificados? Certificados { get; set; }
        //       public ICollection<Proveedores>? Proveedores { get; set; }
        //       public ICollection<Porcentajes>? Porcentajes { get; set; }
        //       public ICollection<Impuestos>? Impuestos { get; set; }
        //       public ICollection<Descuentos>? Descuentos { get; set; }
        //      public ICollection<PlanDeCuentas>? PlanDeCuentas { get; set; }
        //       public ICollection<TipoDeCosto>? TipoDeCosto { get; set; }
        //      public ICollection<Rubros>? Rubros { get; set; }
        //       public ICollection<SubRubros>? SubRubros { get; set; }
        //      public ICollection<Tareas>? Tareas { get; set; }
        //      public ICollection<Insumos>? Insumos { get; set; }


    }
}
