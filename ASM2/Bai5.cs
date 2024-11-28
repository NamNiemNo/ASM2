using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Bai5
    {
        public object TruyXuat(object[] array, int index)
        {
            if (array.Length == 0)
                throw new ArgumentNullException("mang khong duoc null");

            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("index ngoai mang");

            return array[index];
        }
    }
}
