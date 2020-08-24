using System;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int Va;
            Console.WriteLine("contador");
            Console.WriteLine("Escribe el numero:");
            Va =Convert.ToInt32 (Console.ReadLine());

            for(int i = 1; i<= Va; i++)
            {
            Console.Write(" "+ i);
            }
            }
                catch(Exception error){
                Console.WriteLine(error.Message);
            }


        }
    }
}
