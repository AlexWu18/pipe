using System;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int C,D;
            int[] numeros;
            Console.WriteLine("Promedio");
            try
            {
            Console.WriteLine("escriba los numeros para el promedio");
            C = Convert.ToInt32(Console.ReadLine());
            numeros = new int[C];

            int suma = 0;
                for(int i = 0; i<C; i++ )
                {
                numeros[i]= Convert.ToInt32(Console.ReadLine());
                suma = suma + numeros[i];
                }
                D = suma / C;
                Console.WriteLine("promedio es:" + D);

            }
                catch(Exception error)  
                {
                Console.WriteLine(error.Message);
                }
        }
    }
}

