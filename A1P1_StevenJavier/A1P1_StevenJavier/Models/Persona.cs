using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace A1P1_StevenJavier.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required, Min(0), Max(1_000_000)]
        public double Monto { get; set; }
    }
}
