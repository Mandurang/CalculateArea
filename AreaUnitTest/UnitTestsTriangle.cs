using CalculateArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUnitTest
{
    [TestClass]
    public class UnitTestsTriangle
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            var triangle = new Triangle(3, 2, 4);

            // Act
            var result = triangle.CalculateAreaFigure();

            // Assert
            Assert.AreEqual(2.9047375096556, result);
        }
    }
}
