using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1_CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegado dlg = new Delegado();
            int N1 = 0;
            double promedio = 0.00;
            int acumulo = 0;
            for (int i = 0; i < 7; i++)
            {
                try
                {
                    Console.WriteLine("Asigne los grados que surtieron en toda la semana, asigne del dia:"+(i+1));
                    N1 = int.Parse(Console.ReadLine());
                    acumulo = N1 + acumulo;
                }
                catch
                {
                    Console.WriteLine("Este no es un numero entero");
                    i--;

                }
            }
            promedio = acumulo / 7;
            var promedio2 = Delegado.opero(promedio, (x)=> { return x; });
            Console.WriteLine("Promedio:"+promedio2);
            if (promedio2 > 35.00)
            {
                Console.WriteLine("Que semana tan calurosa");
            }
            else if (promedio2 < 15.00)
            {
                Console.WriteLine("Que semana tan fria");
            }
            else if(promedio2>=15.00 && promedio2 <=35.00)
            {
                Console.WriteLine("Que clima tan delicioso");
            }
            Console.ReadKey();
            
        }
    }
}
