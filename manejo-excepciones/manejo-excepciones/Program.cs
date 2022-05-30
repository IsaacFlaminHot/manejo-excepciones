using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            try
            {
                Console.Write("¿Cual es el numero entero a ingresar?: ");
                Numero = int.Parse(Console.ReadLine());

                Console.WriteLine(Math.Pow(Numero, 2));
            }

            catch (FormatException x)
            {
                Console.WriteLine(x.Message);
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado es muy grande.");
            }
        }
    }
}
