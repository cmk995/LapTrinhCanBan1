using System;

namespace GiaiPhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai PTB2");
            // căn bậc hai
            Console.WriteLine("Nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c");
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
                return;
            // a != 0 

            double d = Math.Pow(b, 2) - 4 * a * c;
             d = b*b - 4 * a * c;
            // kiem tra d
            if (d < 0) {
                Console.WriteLine("ptvn");
                return;
            }
            // d >= 0
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("X1= {0:F2}, X2= {1:F2} ", x1, x2);


        }
    }
}
