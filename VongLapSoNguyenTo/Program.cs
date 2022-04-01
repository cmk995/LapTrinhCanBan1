using System;

namespace VongLapSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap N:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i++)
            {
                // chia hết
                if (N % i == 0)
                {
                    if (N == i)
                    {
                        Console.WriteLine("là NT");
                    }
                    else
                    {
                        Console.WriteLine("Không là NT");
                    }
                    // thoat khoi vong lap gan nhat
                    break;
                }
            }


        }
    }
}
