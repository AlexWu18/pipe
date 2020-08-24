using System;

namespace Maximo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int C;
            int[] Numeros;
            int grande;
            try
            {
                Console.WriteLine("coloque la cantidad de numero:");
                C = int.Parse(Console.ReadLine());
                Numeros = new int[C];
                Console.Clear();
                for (int i = 0; i < C; i++)
                {
                    Numeros[i] = int.Parse(Console.ReadLine());
                }
                grande = Numeros[0];

                for (int i = 0; i < C; i++)
                {
                    if (Numeros[i] > grande)
                    {
                        grande = Numeros[i];
                    }
                }
                Console.WriteLine("El mayor es :" + (grande));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }  
    }
}
