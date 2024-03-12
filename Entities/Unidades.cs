using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ProyectoCeroCuadrado.Entities
{
    public class Unidades
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime? Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public ICollection<Insumos> Insumos { get; set; }
        public ICollection<Tareas> Tareas { get; set; }


        //       public Insumos? Insumos { get; set; }
        //      public int? InsumosId { get; set; }


        // public Tareas? Tareas { get; set; }
        // public int? TareasId { get; set; }
    }
}
