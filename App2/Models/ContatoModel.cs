using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace App2.Models
{
    public class ContatoModel
    {
        // Tabla do código. 
        // Seus atributos.
        public int id { get; set; }
        
        [Required(ErrorMessage = "Digite o Nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "O e-mail é inválido!")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Digite o telefone")]
        [Phone(ErrorMessage = "O número é inválido!")]
        public string Telefone { get; set; }
    }
}
