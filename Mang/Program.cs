using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang1 = { 1, 2, 3, 4, 3, 45, 34, 534, 53, 9 };
            int min;
            // duyet mang
            for (int i = 0; i < mang1.Length; i++)
            {
                min = i;
                // tim vi tri của phan tu giá tri nho nhất
                for (int j = i; j < mang1.Length; j++)
                {
                    if (mang1[min] > mang1[j])
                    {
                        min = j;
                    }
                }
                // hoang vị min và i
                int temp = mang1[i];
                mang1[i] = mang1[min];
                mang1[min] = temp; 
            }
            // xuất mang
            for (int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
            }

                int tong = 0;
            for (int i = 0; i < mang1.Length; i++)
            {
                tong += mang1[i];
                //tong = tong + mang1[i];
            }
            //Array.Sort(mang1);


            Console.WriteLine("Tong {0}", tong);
            // truy xuất mang
            for (int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
                if (mang1[i] == 3)
                {
                    Console.WriteLine("vi tri: {0}", i);

                }

            }


        }
    }
}
