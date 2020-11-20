using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1_CONSOLA
{
    delegate double Operar(double a);
    delegate String proceso(String msj);
    class Delegado
    {
        public static double opero(double x,Operar delg)
        {
            return x;
        }
        
    }
}
