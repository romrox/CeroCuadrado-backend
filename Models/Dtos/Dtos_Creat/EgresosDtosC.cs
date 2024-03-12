using System.ComponentModel.DataAnnotations;

namespace CeroCuadrado.Models.Dtos.Dtos_Creat
{
    public class EgresosDtosC
    {   
        public long? VoucherNumber { get; set; }
        public string? Description { get; set; }
        public float? Networth { get; set; }

        public float FinalValue { get; set; }

    }
}
