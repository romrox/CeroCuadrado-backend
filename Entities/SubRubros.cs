using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class SubRubros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
 
        public string? Name { get; set; }
        public string? ShortName { get; set; }

        public DateTime? Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        // public Presupuesto? Presupuesto { get; set; }
        // public int? PresupuestoId { get; set; }

        // public Rubros? Rubros  { get; set; }
        //public int? RubrosId { get; set; }
       // public ICollection<Unidades>? Unidades { get; set; }
      //  public ICollection<Tareas>? Tareas { get; set; }
    }
}
