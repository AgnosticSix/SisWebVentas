using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisWebVentas.Models;
namespace SisWebVentas.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult AddOrEdit(int id = 0)
        {
            PERSONAS personasModel = new PERSONAS();
            return View(personasModel);
        }
    }
}