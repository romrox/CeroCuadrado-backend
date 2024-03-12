
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;

using CeroCuadrado.Entities;

namespace ProyectoCeroCuadrado.Entities
{
    public class TipoDeCosto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }

        public DateTime? Date { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }  


       // public Presupuesto? Presupuesto { get; set; }
      //  public int? PresupuestoId { get; set; }

        // public ICollection<Rubros>? Rubros { get; set; }

//        public Egresos? Egresos { get; set; }
        //public int? EgresosId { get; set; }


//        public Ingresos? Ingresos { get; set; }
        //public int? IngresosId { get; set; }


    }
}
