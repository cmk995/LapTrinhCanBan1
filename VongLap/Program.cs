using System;

namespace VongLap
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Xin Chào");

            }
            #region Tinh Giai 5 Thua
            int gt = 1;
            for (int i = 1; i <= 5 ; i++)
            {
                gt = gt * i;
            }
            Console.WriteLine("5! = {0}", gt);
            #endregion

            #region Tinh N Giai Thua
            int giaiThua = 1;
            Console.WriteLine("Nhap N:");
            // nhap N tu ban phim
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                giaiThua = giaiThua * i; 
            } 
            Console.WriteLine("{1}! = {0}", giaiThua, N);


            #endregion

        }
    }
}
