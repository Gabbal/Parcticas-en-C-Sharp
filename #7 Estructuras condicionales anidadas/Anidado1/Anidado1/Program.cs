using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.*/

namespace Anidado1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("El numero mayor es: ");
                    Console.Write(num1);
                }
                else
                {
                    Console.Write("El numero mayor es: ");
                    Console.Write(num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write("El numero mayor es: ");
                    Console.Write(num2);
                }
                else
                {
                    Console.Write("El numero mayor es: ");
                    Console.Write(num3);
                }
            }

            Console.ReadKey();
        }
            
    }
}
