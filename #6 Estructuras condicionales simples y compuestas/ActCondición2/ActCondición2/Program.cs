using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado".*/

namespace ActCondición2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            string linea;

            Console.Write("Ingrese la primer nota: ");
            linea = Console.ReadLine();
            nota1 = float.Parse(linea);

            Console.Write("Ingrese la segunda nota: ");
            linea = Console.ReadLine();
            nota2 = float.Parse(linea);

            Console.Write("Ingrese la tercer nota: ");
            linea = Console.ReadLine();
            nota3 = float.Parse(linea);

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7) 
            {
                Console.Write("Promocionado");
            }

            Console.ReadKey();
        }
    }
}
