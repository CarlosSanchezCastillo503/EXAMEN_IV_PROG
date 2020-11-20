using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class EJERCICIOController : Controller
    {
        // GET: EJERCICIO
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Deportista()
        {
            Deportista depo = new Deportista();
           
            depo.Edad = Int32.Parse(Request.Form["edad"].ToString());
            depo.Estatura = Double.Parse(Request.Form["estatura"].ToString());
            depo.Peso = Double.Parse(Request.Form["peso"].ToString());
            if (depo.Peso < 80 && depo.Edad<=18 && depo.Estatura>180)
            {
                depo.Msj = "Felicidades, eres un nuevo atleta";
            }
            else
            {
                depo.Msj = "Huy, tu no cumples con los requisitos dados";
               
            }

            return View("resultado_deportista",depo);
        }
    }
}