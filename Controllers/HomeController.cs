using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastro_de_alunos.Models;

namespace Cadastro_de_alunos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Aluno aluno)
        {
            BaseDados.Incluir(aluno);
            ViewBag.Mensagem = "Cadastro realizado         com sucesso";
            return View();
        }
        public IActionResult Listagem()
        {
            List<Aluno> listar = BaseDados.Listar();
            return View(listar);
        }
    }
}
