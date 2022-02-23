using Class_01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_01.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> lsPessoa = new List<Pessoa>();
        public IActionResult Index()
        {
            return View(lsPessoa);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Salvar(Pessoa itemA)
        {
            lsPessoa.Add(itemA);
            return RedirectToAction("Index");
        }
    }
}
