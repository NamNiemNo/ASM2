using ASM2;

namespace TestProject
{
    public class Tests
    {
       private Bai1TinhTong _bai1 = new Bai1TinhTong();
        [Test]
        [TestCase(8.9, 21)]
        [TestCase(12, 12.4)]
        [TestCase(5.5, 6.5)]
        public void Test1(double a, double b)
        {
            Assert.Throws<ArgumentException>(() =>{_bai1.TinhTong(a, b);});
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(7, 8, 15)]
        [TestCase(20, 10, 30)]
        [TestCase(-3, 5, 2)]
        [TestCase(-5, -10, -15)]
        [TestCase(-8, -7, -15)]
        public void Test2(double a, double b, double result)
        {
            Assert.That(_bai1.TinhTong(a, b), Is.EqualTo(result));
        }
    }
}