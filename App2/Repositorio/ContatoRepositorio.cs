using App2.Data;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Repositorio
{
    public class ContatoRepositorio :  IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext= bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato){
            // gravar no db
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
        public List <ContatoModel> BuscarTodos(){
            return _bancoContext.Contatos.ToList();
        }
    }
}