using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisWebVentas.Models;
namespace SisWebVentas.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Crear (int id = 0)
        {
            PRODUCTOS productosModel = new PRODUCTOS();
            return View(productosModel);
        }
    }
}