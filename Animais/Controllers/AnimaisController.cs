using Microsoft.AspNetCore.Mvc;
using Animais.Data;
using Animais.Models;
using System;

namespace Animais.Controllers
{
    public class AnimaisController : Controller
    {
        readonly private ApplicationDbContext _context;

        public AnimaisController()
        {
            var context = new ApplicationDbContext();

            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<AnimaisModels> animaisModels = _context.AnimaisModels;
            return View(animaisModels);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            AnimaisModels animais = _context.AnimaisModels.FirstOrDefault(x => x.Id == id);
            return View(animais);
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            AnimaisModels animais = _context.AnimaisModels.FirstOrDefault(x => x.Id == id);
            return View(animais);
        }

        [HttpPost]
        public IActionResult Cadastrar(AnimaisModels animaisModels)

        {
            _context.Add(animaisModels);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(AnimaisModels animaisModels)

        {
            _context.Update(animaisModels);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Excluir(AnimaisModels animaisModels)

        {
            _context.Remove(animaisModels);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}