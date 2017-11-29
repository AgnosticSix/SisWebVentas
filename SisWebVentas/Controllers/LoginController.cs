using SisWebVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisWebVentas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autorizar(SisWebVentas.Models.USUARIOS userModel)
        {
            using (SisWebVentasEntities1 db = new SisWebVentasEntities1())
            {
                var userDetails = db.USUARIOS.Where(x => x.USUARIO == userModel.USUARIO && x.CONTRASENA == userModel.CONTRASENA).FirstOrDefault();
                if(userDetails == null)
                {
                    userModel.LoginErrorMessage = "Usuario o contraseña incorrectos";
                    return View("Login", userModel);
                }
                else
                {
                    Session["cve_usuario"] = userDetails.CVE_USUARIO;
                    return RedirectToAction("Login", "Index");
                }
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}