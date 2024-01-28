using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App2.Models;

namespace App2.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListaPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}