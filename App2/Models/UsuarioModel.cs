using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App2.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App2.Models

{
    public class UsuarioModel
    {
        public int Id{get; set;}

        [Required(ErrorMessage = "Digite o Nome")]
        public string Nome{get; set;}
        
        [Required(ErrorMessage = "Digite o login")]
        public string Login{get; set;}

        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "O e-mail é inválido!")]
        public string Email{get; set;}
        public PerfilEnum Perfil { get; set;}
        
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha {get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime? DataAtualizaçao{get; set;}
    }
}