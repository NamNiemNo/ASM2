using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Bai5Test
    {
        private Bai5 bai5 = new Bai5();
        [Test]
        [TestCase(new object[] {}, 0)]
        [TestCase(new object[] {}, -1)]       
        public void Exception1(object[] array, int index)
        {
            Assert.Throws<ArgumentNullException>(() => { bai5.TruyXuat(array, index); });
        }
        [Test]
        [TestCase(new object[] { 1, 2, 3, 4, 5 }, 9)]
        [TestCase(new object[] { 1, 2, 3, 4, 5 }, -3)]
        [TestCase(new object[] { 1, 2, 3, 4, 5 }, -11)]
        public void Exception2(object[] arr, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => { bai5.TruyXuat(arr, index); });
        }
        [Test]
        [TestCase(new object[] { 1, 2, 3 }, 0, 1)]
        [TestCase(new object[] { 1, 2, 3 }, 1, 2)]
        [TestCase(new object[] { 1, 2, 3 }, 2, 3)]
        [TestCase(new object[] { "a", "b", "c" }, 1, "b")]
        [TestCase(new object[] { true, false, true }, 0, true)]
        public void TestHopLe(object[] array, int index, object expected)
        {
            Assert.That(bai5.TruyXuat(array, index), Is.EqualTo(expected));
        }

    }
}
