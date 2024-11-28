using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Bai3TinhHieu
    {
        public double TinhHieu(double a, double b)
        {
            if (a != Math.Floor(a) || b != Math.Floor(b))
            {
                throw new ArgumentException("cac so phai la so nguyen");
            }
            return a - b;
        }
    }
}
