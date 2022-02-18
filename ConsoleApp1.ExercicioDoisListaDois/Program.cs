using System;

namespace ConsoleApp1.ExercicioDoisListaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício dois // Lista Dois");
            int X, Y, Z;
            do
            {
                Console.Write("Digite o valor X: ");
                X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor Y: ");
                Y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor Z: ");
                Z = Convert.ToInt32(Console.ReadLine());
                if (X > Y && Y > Z)
                    Console.WriteLine("{0} {1} {2}", X, Y, Z);
                else if (X > Y && X > Z && Z > Y)
                    Console.WriteLine("{0} {1} {2}", X, Z, Y);
                else if (Y > X && X > Z)
                    Console.WriteLine("{0} {1} {2}", Y, X, Z);
                else if (Y > X && Y > Z && Z > X)
                    Console.WriteLine("{0} {1} {2}", Y, Z, X);
                else if (Z > Y && Y > X)
                    Console.WriteLine("{0} {1} {2}", Z, Y, X);
                else if (Z > Y && X > Y)
                    Console.WriteLine("{0} {1} {2}", Z, X, Y);

            } while (true);


        }
    }
}
