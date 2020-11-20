using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class NumerosController : Controller
    {
        // GET: Numeros
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Resolucion()
        {
            Numeros Num = new Numeros();
            //depo.Edad = Int32.Parse(Request.Form["edad"].ToString());
            Num.N1 = Int32.Parse(Request.Form["N1"].ToString());
            Num.N2 = Int32.Parse(Request.Form["N2"].ToString());
            if (Num.N1 < Num.N2)
            {
                Num.R = Num.N2 / Num.N1;
                Num.Msj = "N2 es mayor que N1";
                Num.Msj2 = "Se procede a una Division";
                Num.Msj3 = "" + (Num.N2 - Num.N1);
            }
            else
            {
                Num.R = Num.N2+Num.N1;
                Num.Msj = "N1 es mayor que N2";
                Num.Msj2 = "Se procede a una Suma";
                Num.Msj3 = "" + (Num.N1 - Num.N2);
            }
            return View("Resolucion", Num);
        }
    }
}