using System;

namespace XepLoaiHocLuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Diem:");
            double diem =
                double.Parse(Console.ReadLine());
            // kiem tra diem co hopm le khong 
            if (diem < 0 || diem > 10)
            {
                // khong hop le
                Console.WriteLine("Diem không hop le:");
                Console.ReadKey();
                return;
                // kết thuc hàm 
            }
            // diem da hop le
            if (diem < 4)
            {
                Console.WriteLine("Yeu");
                return;
            }
            if (diem < 5)
            {
                Console.WriteLine("Trung Binh");
                return;
            }
            if (diem < 6.5)
            {
                Console.WriteLine("Trung Binh Kha");
                return;
            }
            if (diem < 8.5)
            {
                Console.WriteLine("Kha");
                return;
            }
            Console.WriteLine("Gioi");
            return;  
        }
    }
}
