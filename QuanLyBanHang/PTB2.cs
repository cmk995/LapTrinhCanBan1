using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanHang
{
    class PTB2
    {
        public PTB2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public string GiaiPhuongTrinh()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                return string.Format("PT Vô Nghiệm");
            }
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return string.Format("X1= {0:f2} ,\n X2={1:f2}", x1, x2);
        }
    }
}
