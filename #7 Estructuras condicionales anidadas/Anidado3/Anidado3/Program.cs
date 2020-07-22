using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y muestre un mensaje 
 indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.*/

namespace Anidado3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;

            Console.Write("Ingrese un valor de hasta tres dígitos positivo: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            if (num <= 999)
            {
                if (num <= 9)
                {
                    Console.Write("El numero ingresado tiene 1 cifra.");
                }
                else
                {
                    if (num <= 99)
                    {
                        Console.Write("El numero ingresado tiene 2 cifras.");
                    }
                    else
                    {
                        Console.Write("El numero ingresado tiene 3 cifras.");
                    }
                }
            }
            else
            {
                Console.Write("Error en la entrada de datos.");
            }

            Console.ReadKey();
        }
    }
}
