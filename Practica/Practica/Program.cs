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
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu edad");
            string texto = Console.ReadLine();

            int edad = Convert.ToInt32(texto);

            Console.WriteLine ("Te llamas " +nombre+" y tienes "+edad+ " años" );

            Console.ReadLine();

        }
    }
}
