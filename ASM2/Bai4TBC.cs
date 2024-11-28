using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Bai4TBC
    {
        public double TBC(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentNullException("Danh Sach Trong.");
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
    }
}
