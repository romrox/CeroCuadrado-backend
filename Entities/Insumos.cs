using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class Insumos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public float? Cost { get; set; }
        public DateTime? Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        public int UnidadesId { get; set; }
        public string UnidadesName { get; set; }
        public Unidades Unidades { get; set; }  // Propiedad de navegación

       // public ICollection<Proveedores>? Proveedores { get; set; }
       // public ICollection<TipoDeOperaciones>? TipoDeOperaciones { get; set; }
        // public Presupuesto? Presupuesto { get; set; }
        //public int? PresupuestoId { get; set; }
        //   public Tareas? Tareas { get; set; }
        // public int? TareasId { get; set; }
        //      public Unidades? Unidades { get; set; }
    }
}
