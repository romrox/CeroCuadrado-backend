using CeroCuadrado.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class TipoDeOperaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime? Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }


//        public Egresos? Egresos { get; set; }
 //       public int? EgresosId { get; set; }


//        public Ingresos? Ingresos { get; set; }
 //       public int? IngresosId { get; set; }
    } 
}
