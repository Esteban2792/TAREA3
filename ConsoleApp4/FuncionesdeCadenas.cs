using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class FuncionesdeCadenas
    {

        public void principal()
        {
            //string correo = "";
            //Console.WriteLine("Digite su correo: ");
            //correo = Console.ReadLine();
            //string nombre;
            //byte k;
            //Console.WriteLine("Digite su nombre: "); nombre = Console.ReadLine();
            //Console.WriteLine("Longitud: " + nombre.Length);
            //Console.WriteLine($"Esta dentro: {nombre.Contains("Dead")}");
            //Console.WriteLine($"En Minuscula {nombre.ToLower()}");
            //Console.WriteLine($"En Mayuscula {nombre.ToUpper()}");
            //nombre = nombre.ToUpper();
            //Console.WriteLine("Reemplazar una vocal a: " + nombre.Replace("A","I").ToUpper());
            //Console.WriteLine("Remover: " + nombre.Remove(3,4));
            //Console.WriteLine("Extraer 4 letras: " + nombre.Substring(3,4));
            //Console.WriteLine($"Izquierda 4 letras: {nombre.PadLeft(4)}" );
            //Console.WriteLine("Extraer un caracter: " + nombre.IndexOf("IOS"));
            //Console.WriteLine();
            //if (correo.Contains("@") && correo.Contains("."))
            //{
            //    int longitud = correo.Length;
            //    int pos = correo.IndexOf('@');
            //    string dominio = correo.Substring(pos,longitud-pos);
            //    Console.WriteLine($"Dominio: {dominio}");
            //}
            //else
            //{
            //    Console.WriteLine("Esto no es un correo");
            //}


            // Console.Read();


            String[] letras = new String[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", ""};
            String[] enigma = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "j", "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };
            Console.WriteLine("Digite una frase: ");
            String frase = Console.ReadLine().ToLower();
            String codigo = "";

            foreach (char letra in frase)
            {
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i].Equals(letra.ToString()))
                    {
                        codigo += enigma[i];
                        break;
                    }
                }
            }
            Console.WriteLine("Codigo: {0}", codigo);
            Console.WriteLine();
            //desencriptar
            Console.WriteLine("El codigo es: {0}", codigo);
            String frase2 = "";
            foreach (char letra in codigo)
            {
                for (int i = 0; i < enigma.Length; i++)
                {
                    if (enigma[i].Equals(letra.ToString()))
                    {
                        frase2 += letras[i];
                        break;
                    }
                }

            }
            Console.WriteLine("Frase: {0}", frase2);
            Console.ReadKey();
        }
    }
}
/* 1. Validar @
 * 2. Extraer todo lo que esta despues del @
 * 3. Validar .com
 */