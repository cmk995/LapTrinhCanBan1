using System;

namespace GiaiPhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai PTB1");
            Console.WriteLine("Nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            double b = double.Parse(Console.ReadLine());
            // nếu a = 0
            #region Cách 1 
            if (a == 0)
            {
                if (b == 0)
                {
                    // b==0
                    Console.WriteLine("PTVSN");
                }
                else
                {
                    // b!=0
                    Console.WriteLine("PTVN");
                }
            }
            else
            {
                // a != 0
                Console.WriteLine("Nghiem cua PT la{0:F2}", -b / a);
            }
            #endregion
            #region Cách 2
            if (a == 0)
            {
                if (b == 0)
                {
                    // b==0
                    Console.WriteLine("PTVSN");
                    return;
                }
                else
                {
                    // b!=0
                    Console.WriteLine("PTVN");
                    return;

                }
            }
            // a != 0
            Console.WriteLine("Nghiem cua PT la{0:F2}", -b / a);
            #endregion
        }
    }
}
