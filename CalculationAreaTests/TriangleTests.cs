using CalculationArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationAreaTests
{
    internal class TriangleTests
    {
        [Test]
        public void CalculateArea_Triangle_SuccessfulTest()
        {
            var triangle = new Triangle(3, 4, 5);
            //Assert.AreEqual(6, triangle.CalculateArea(), 1e-11);
            Assert.That(6, Is.EqualTo(triangle.CalculateArea()));
        }

        [Test]
        public void IsRightTriangleInt_SuccessfulTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void IsRightTriangleDouble_SuccessfulTest()
        {
            var triangle = new Triangle(5.2, 6.5, 8.324061508662703);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void IsNotRightTriangleInt_SuccessfulTest()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [Test]
        public void IsNotRightTriangleDouble_SuccessfulTest()
        {
            var triangle = new Triangle(5.2, 6.5, 9.324061508662703);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }

}
