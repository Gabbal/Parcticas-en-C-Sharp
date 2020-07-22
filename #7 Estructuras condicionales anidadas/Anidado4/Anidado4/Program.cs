using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: cantidad total de 
 preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente. Se pide confeccionar un programa 
 que ingrese los dos datos por teclado e informe el nivel del mismo según el porcentaje de respuestas correctas que ha 
 obtenido*/

namespace Anidado4
{
    class Program
    {
        static void Main(string[] args)
        {
            int preguntas, respuestas;
            float total;
            string linea;

            Console.Write("Ingrese la cantidad total de preguntas del examen: ");
            linea = Console.ReadLine();
            preguntas = int.Parse(linea);

            Console.Write("Ingrese la cantidad total de preguntas contestadas correctamente: ");
            linea = Console.ReadLine();
            respuestas = int.Parse(linea);

            total = (respuestas * 100) / preguntas;

            if (total >= 90)
            {
                Console.Write("Nivel Máximo: " + total + "%");
            }
            else
            {
                if (total >= 75)
                {
                    Console.Write("Nivel Medio: " + total + "%");
                }
                else
                {
                    if (total >= 50)
                    {
                        Console.Write("Nivel Regular: " + total + "%");
                    }
                    else
                    {
                        Console.Write("Fuera de nivel: " + total + "%");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
