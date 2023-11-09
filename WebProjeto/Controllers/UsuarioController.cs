using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProjeto.Models;

namespace WebProjeto.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", cliente);
            }
            return View(cliente);
        }

        public ActionResult Resultado(Cliente cliente)
        {
            return View(cliente);
        }
    }
}