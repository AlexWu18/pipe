using System;

namespace Maxima
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int C;
            int[] numero;
            int grande;
            Console.WriteLine("Coloque la cantidad de numeros");
            C = Convert.ToInt32(Console.ReadLine());
            numero = new int[C];

            for(int i = 0; i< C; i++)
            {
                numero[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            grande = numero[0];
            for(int i = 0; i< C; i++)
            {
                if(numero[i] > grande)
                {
                    grande = numero[i];
                }
            }
            Console.WriteLine("El mayor es : " + grande);
            }
            catch(Exception error)
            {
            Console.WriteLine(error.Message);
            }
        }
    }
}
