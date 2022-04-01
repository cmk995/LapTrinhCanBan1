using System;

namespace ToanTuSoSanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap A:");

            //C1 //int a = int.Parse(Console.ReadLine());
            //C2
            string inputA = Console.ReadLine();
            int a = int.Parse(inputA);

            if (a%2==0)
            {
                Console.WriteLine("La So Cham");
            }
            else
            {
                Console.WriteLine("la So Lẻ");
            }
              
        }
    }
}
