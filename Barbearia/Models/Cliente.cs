using System.ComponentModel.DataAnnotations;

namespace Barbearia.Models
{
    public class Cliente
    {
       
        public int IdCliente { get; set; }
        [Required]
        public string Number { get; set; } = string.Empty;
       
        [Required]
        public string Message { get; set; } = string.Empty;


    }
}
