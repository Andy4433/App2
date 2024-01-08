using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Models
{
    public class ContatoModel
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}