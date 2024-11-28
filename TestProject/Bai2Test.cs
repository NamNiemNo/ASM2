using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Bai2Test
    {
        private Bai2TinhTich _bai2 = new Bai2TinhTich();
        [Test]
        [TestCase(1.5, 2)]      
        [TestCase(3, 2.7)]   
        [TestCase(2.5, 3.5)]    
        [TestCase(-1.1, 5)]     
        [TestCase(6, -2.8)]
        public void Test1(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => { _bai2.TinhTich(a, b); });
        }
        [Test]
        [TestCase(2, 3, 6)]     
        [TestCase(-4, 5, -20)]  
        [TestCase(-6, -7, 42)] 
        [TestCase(0, 10, 0)]   
        [TestCase(1, 100, 100)]
        public void Test2(double a, double b, double result)
        {
            Assert.That(_bai2.TinhTich(a, b), Is.EqualTo(result));
        }

    }
}
