using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Menu
    {
        static int opcion;

        public void menup()
        {
            do
            {
                Console.WriteLine("1- Opcion 1");
                Console.WriteLine("2- Opcion 2");
                Console.WriteLine("3- Salir");
                opcion = Console.Read();
                switch (opcion)
                {
                    case 1: break;
                    case 2: Submenup(); break;
                    case 3: break;
                    default:
                        break;
                }
            } while (opcion != 3);
        }

        public void Submenup()
        {
            do
            {
                Console.WriteLine("1- Opcion 1");
                Console.WriteLine("2- Opcion 2");
                Console.WriteLine("3- Salir");
                opcion = Console.Read();
                switch (opcion)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    default:
                        break;
                }

            } while (opcion != 3);
        }

    }

}