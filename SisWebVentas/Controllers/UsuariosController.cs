using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisWebVentas.Models;

namespace SisWebVentas.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult AddOrEdit(int id = 0)
        {
            USUARIOS usuariosModel = new USUARIOS();
            return View(usuariosModel);
        }
    }
}