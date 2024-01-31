using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App2.Models;

namespace App2.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListaPorId(int Id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int Id);
    }
}