using App2.Repositorio;
using App2.Models;
using Microsoft.AspNetCore.Mvc;

namespace App2.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        
        public IActionResult Index()
        {
            var contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
        
        public IActionResult Criar()
        {
            return View();
        }
        
        public IActionResult Deletar(int id)
        {
            var contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }
        
        public IActionResult Del(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult Editar(int id)
        {
            var contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }
        
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
