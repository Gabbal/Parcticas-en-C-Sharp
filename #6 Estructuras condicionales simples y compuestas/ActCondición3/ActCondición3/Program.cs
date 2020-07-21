using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número 
 tiene uno o dos dígitos. (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)*/

namespace ActCondición3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.Write("Ingrese un valor entero de 1 o 2 dígitos: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if (numero < 10) 
            {
                Console.Write("Tiene un dígito");
            } else
            {
                Console.Write("Tiene dos dígitos");
            }

            Console.ReadKey();
        }
    }
}
