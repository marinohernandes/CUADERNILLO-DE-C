using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, EM;
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Determinar cual de las tres edadades es mayor");
            //Entrada
            Console.WriteLine("Ingresa la primer edad");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda edad");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la tercera edad");
            C = double.Parse(Console.ReadLine());
            //Proceso y salida
            if (A > B)
            {
            if (A >C)
                {
                   EM = A;
                    }
                  else
                    {
                        EM = C;
                    }
                }
            else
                {
                    if (B > C)
                    {
                        EM = B;
                }
                    else
                    {
                        EM= C;
                    }
            }
            Console.WriteLine("La edad mayor es: " + EM);
            Console.ReadKey();
        }
    }
}
