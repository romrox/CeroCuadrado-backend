using CeroCuadrado.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCeroCuadrado.Entities
{
    public class FormaDePago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }

        public DateTime? Data { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }


        //   public Egresos? Egresos { get; set; }
        //   public int? EgresosId { get; set; }


        //   public Ingresos? Ingresos { get; set; }
        //  public int? IngresosId { get; set; }
    }
}
