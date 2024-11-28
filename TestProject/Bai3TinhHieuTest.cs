using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Bai3TinhHieuTest
    {   private Bai3TinhHieu _bai3 = new Bai3TinhHieu();
        [Test]
        [TestCase(1.5, 2)]
        [TestCase(3, 2.7)]
        [TestCase(2.5, 3.5)]
        [TestCase(-1.1, 5)]
        [TestCase(6, -2.8)]
        public void TestInvalidInputs(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => { _bai3.TinhHieu(a, b); });
        }

        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(-4, 5, -9)]
        [TestCase(-6, -7, 1)]
        [TestCase(0, 10, -10)]
        [TestCase(100, 1, 99)]
        public void TestValidInputs(double a, double b, double result)
        {
            Assert.That(_bai3.TinhHieu(a, b), Is.EqualTo(result));
        }

    }
}
