using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;

namespace ProyectoCeroCuadrado.Entities
{
    public class Rubros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? ShortName { get; set; }


        public DateTime Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

       // public Presupuesto? Presupuesto { get; set; }
//public int? PresupuestoId { get; set; }
      //  public ICollection<SubRubros>? SubRubros { get; set; }

    //    public PlanDeCuentas? PlanDeCuentas { get; set; }
      //  public int? PlanDeCuentasId { get; set; }
    }
}
