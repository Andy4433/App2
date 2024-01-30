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
            try
            {
                bool apagado = _contatoRepositorio.Apagar(id);
                if (apagado){
                    TempData["MensagemSucesso"] = "Contato Apagado com sucesso";
                    
                }
                else{
                    TempData["MensagemErro"] = $"Ops, algo deu errado, verifique e tente novamente.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, algo deu errado, verifique e tente novamente. \n detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        
        public IActionResult Editar(int id)
        {
            var contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }
        
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if(ModelState.IsValid){
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);
                }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, algo deu errado, verifique e tente novamente. \n detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
           try
           {
                if (ModelState.IsValid){
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato editado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);
           }
           catch (System.Exception erro)
           {
            
                TempData["MensagemErro"] = $"Ops, algo deu errado, verifique e tente novamente. \n detalhe: {erro.Message}";
                return RedirectToAction("Index");
           }
        }
    }
}
