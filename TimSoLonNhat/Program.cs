using System;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C:");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine("{0} la lon nhat",max);


        }
    }
}
