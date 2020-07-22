using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el número es positivo, nulo o negativo.*/

namespace Anidado2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            if (num > 0)
            {
                Console.Write("El numero ingresado es positivo.");
            }
            else
            {
                if(num == 0)
                {
                    Console.Write("El numero ingrasado es nulo.");
                }
                else
                {
                    Console.Write("El numero ingresado es negativo.");
                }
            }

            Console.ReadKey();
        }
    }
}
