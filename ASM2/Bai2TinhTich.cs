using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Bai2TinhTich
    {
        public double TinhTich(double a, double b)
        {
            if (a != Math.Floor(a) || b != Math.Floor(b))
            {
                throw new ArgumentException("cac so phai la so nguyen");
            }
            return a * b;
        }
    }
}
