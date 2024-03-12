using Microsoft.Identity.Client;
using ProyectoCeroCuadrado.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CeroCuadrado.Entities
{
    public class Certificados
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Month {  get; set; }
        public float? Week { get; set;}
        public float? Week2 { get; set; }
        public float? Week3 { get; set; }
        public float? Week4 { get; set; }
        public float? Week5 { get; set; }
        public float? TotalValue { get; set; }
 


    }
}
