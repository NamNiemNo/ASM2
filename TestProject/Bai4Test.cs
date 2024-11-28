using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Bai4Test
    {
        private Bai4TBC _bai4 = new Bai4TBC();

        [Test]
        [TestCase(new double[] {})]
        [TestCaseSource(nameof(Null))]
        public void Exception(double[] numbers)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _bai4.TBC(numbers);
            });
        }
        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 3.0)]
        [TestCase(new double[] { -1, -2, -3 }, -2.0)]
        [TestCase(new double[] { 0, 0, 0 }, 0.0)]
        [TestCase(new double[] { 2.5, 3.5, 4.5 }, 3.5)]
        [TestCase(new double[] { 10, 20, 30 }, 20.0)]
        [TestCase(new double[] { -10, -5, 0 }, -5.0)]
        [TestCase(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 }, 3.3)]
        [TestCase(new double[] { 100, 200, 300, 400, 500 }, 300.0)]
       
        public void TestGiaTriHopLe(double[] numbers, double expectedAverage)
        {
            double result = _bai4.TBC(numbers);
            Assert.That(result, Is.EqualTo(expectedAverage));
        }
        public static IEnumerable<TestCaseData> Null()
        {
            yield return new TestCaseData(null);   
        }
    }
}
