using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class Tareas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        public int UnidadesId { get; set; }  // Propiedad de clave foránea
        public Unidades Unidades { get; set; }  // Propiedad de navegación

        //public ICollection<Unidades>? Unidades { get; set; }
        // public ICollection<Insumos>? Insumos { get; set; }



        // public Presupuesto? Presupuesto { get; set; }
        //public int? PresupuestoId { get; set; }

        //  public SubRubros? SubRubros { get; set; }
        // public int? SubRubrosId { get; set; }
        //        public Unidades? Unidades { get; set; }
        //       public ICollection<Insumos>? Insumos { get; set; }


    } 
}
