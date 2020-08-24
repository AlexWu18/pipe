using System;

namespace Sumatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = 0;
            int[] numero;
            try
            {
            Console.WriteLine("Sumatoria");
            Console.WriteLine("Ingrese los numeros");
            C = Convert.ToInt32(Console.ReadLine());

            int suma = 0;   
            numero = new int[C];
            for(int i = 0; i< C; i++)
            {
            numero[i]= Convert.ToInt32(Console.ReadLine());
            suma = suma + numero[i];
            }
            Console.WriteLine(suma);
            }
            catch(Exception error)
            {
            Console.WriteLine(error.Message);
            }

        }
    }
}
