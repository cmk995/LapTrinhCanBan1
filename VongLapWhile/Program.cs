using System;

namespace VongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kt;
            int a;
            do
            {
                Console.WriteLine("Nhap So Nguyen Duong A:");
                kt = int.TryParse(Console.ReadLine(), out a);
                if (a < 0)
                    kt = false;
            } while (kt == false);
            int b;
            do
            {
                Console.WriteLine("Nhap So Nguyen Duong B:");
                kt = int.TryParse(Console.ReadLine(), out b);
                if (b < 0)
                    kt = false;
            } while (kt == false);
            // ca a va b  > 0
            while (a * b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else {
                    b = b % a;
                } 
            }
            Console.WriteLine("UCLN la : {0}", a + b);


        }
    }
}
