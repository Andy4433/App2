using App2.Repositorio;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App2.Controllers
{

    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatorepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatorepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatorepositorio.BuscarTodos();
            return View(contatos);
        }
         public IActionResult Criar()
        {
            return View();
        }
         public IActionResult Deletar()
        {
            return View();
        }
         public IActionResult Editar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato){
            _contatorepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

    }
}