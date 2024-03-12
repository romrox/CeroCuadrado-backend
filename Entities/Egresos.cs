using ProyectoCeroCuadrado.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CeroCuadrado.Entities
{
    public class Egresos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //fecha
        public DateTime? Date { get; set; } = DateTime.Now;

        //empresas
      //  public ICollection<Empresas>? Empresas { get; set; }
        //centro de costos
     //   public ICollection<CentroDeCostos>? CentroDeCostos { get; set; }
        //tipo de operacion
    //    public ICollection<TipoDeOperaciones>? TipoDeOperaciones { get; set; }
        //concepto
        //     public Porcentajes? Porcentajes { get; set; }
        // va dentro de concepto solo toma el valor total de la obra sin impuestos o porcentajes 
     //   public ICollection<TipoDeCosto>? TipoDeCosto { get; set; }
        //tipo de comprobante
     //   public ICollection<TipoDeComprobante>? TipoDeComprobante { get; set; }
        public long? VoucherNumber { get; set; }
        //proveedores
     //   public ICollection<Proveedores>? Proveedores { get; set; }
        //formas de pago
     //   public ICollection<FormaDePago>? FormaDePago { get; set; }


        public string? Description { get; set; }
        //impuestos
     //   public ICollection<Impuestos>? Impuestos { get; set; }
        public float? Networth { get; set; }
        public float? FinalValue { get; set; }

    }
}
