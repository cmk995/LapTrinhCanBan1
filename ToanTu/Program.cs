using System;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 4;
                // xuất ra màn hình
                Console.WriteLine("Nhap a:");
                // nhap tu ban phim so a
                string inputA = Console.ReadLine();
                //a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap b:");
                // nhap tu ban phim so b
                string inputB = Console.ReadLine();
                //b = int.Parse(Console.ReadLine());

                a = int.Parse(inputA);
                b = int.Parse(inputB);
                //int.TryParse(inputA, out a);
                //int.TryParse(inputB, out b); 
                Console.WriteLine("tong cua a + b la {0} "
                    , a + b);
                Console.WriteLine("tong cua {0} + {1} la {2} "
                    , a, b, a + b);
                Console.WriteLine("hieu cua {0} - {1} la {2} "
                    , a, b, a - b);
                Console.WriteLine("tich cua {0} * {1} la {2} "
                    , a, b, a * b);
                Console.WriteLine("thuong cua {0} / {1} la {2} "
                    , a, b, a / b);
                Console.WriteLine("chia lay du cua {0}%2 la {1} "
                    , a, a % 2);
            }
            catch (Exception ex)
            {
                Main(args);
            }

           


        }
    }
}
