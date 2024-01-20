using App2.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Data
{
    
    public class BancoContext : DbContext
    {
        // Construtor
        // Nele temos  como paramentro de entrada temos o DBContextOption
        // Vamos passa dentro do Dbcontext chamando o (: base(options)) 
        public BancoContext(DbContextOptions<BancoContext> options) : base(options){
        }
        // vamos chamar uma tabela chamada Contatos
        // o DbSet estamos informando a classe que representa a tabela
        public DbSet<ContatoModel> Contatos {get; set;}
    }
}