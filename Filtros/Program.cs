using System;

namespace Filtros
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int C;
            Console.WriteLine("Filtros");
            Console.WriteLine("Ingrese numeros");
            C = Convert.ToInt32(Console.ReadLine());

            if (C % 2 == 0)
            {
                Console.WriteLine("es par " + C);
            }
            else
            {
                Console.WriteLine("no es par");
            }
            }
            catch(Exception error)  
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
