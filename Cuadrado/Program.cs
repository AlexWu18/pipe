using System;

namespace Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            int A, B;
            Console.WriteLine("Cuadrado");
            Console.WriteLine("Ingrese un numero");
            A = Convert.ToInt32(Console.ReadLine());
            B = A * A;
            Console.WriteLine(B);
            }
            catch(Exception error){
                Console.WriteLine(error.Message);
            }
        }
    }
}
