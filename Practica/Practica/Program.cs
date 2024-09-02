using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un dia de la semana");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("Ese dia no es correcto");
                    break;
            }

            Console.ReadLine();


        }
    }
}
