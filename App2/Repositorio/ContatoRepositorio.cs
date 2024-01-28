using App2.Data;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel ListaPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.id == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            // gravar no db
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            // Recuperar o contato do banco de dados
            ContatoModel contatoDB = ListaPorId(contato.id);
            
            // Verificar se o contato existe
            if (contatoDB == null) 
            {
                throw new Exception("Contato não encontrado");
            }
            
            // Atualizar os campos do contato recuperado com os novos valores
            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone = contato.Telefone;
            
            // Atualizar no banco de dados
            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            
            return contatoDB;
        }
        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListaPorId(id);
            if (contatoDB == null) 
            {
                throw new Exception("Contato não encontrado");
            }
            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }

    }
}
