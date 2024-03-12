using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class PlanDeCuentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }


       // public ICollection<TipoDeCosto>? TipoDeCosto { get; set; }



      //  public Presupuesto? Presupuesto { get; set; }
       // public int? PresupuestoId { get; set; }
    }
}
