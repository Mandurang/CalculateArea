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
        public void CalculateTriangleArea_TriangleWithСorrectCatet_CorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 2, 4);

            // Act
            var result = triangle.CalculateAreaFigure();

            // Assert
            Assert.AreEqual(2.9047375096555625, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNonValidCatet_WithNegativeOrZeroParams_ReturnCalculateFigureException()
        {
            // Arrange
            var triangle = new Triangle(-1, 0, 3);
            var exptedMessage = "Area can't be negative or equal 0";

            // Act
            var result = triangle.CalculateAreaFigure();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateAreaFigure(), exptedMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNonValidArea_WithNegativeOrZeroParams_ShouldReturnArgumentException()
        {
            // Arrange
            var triangle = new Triangle(-1, 0, 3);
            var exptedMessage = "Area can't be negative or equal 0";

            // Act
            triangle.IsValidParam();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.IsValidParam(), exptedMessage);
        }

        [TestMethod]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNonRightTriangle_NonValidRightTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 10, 5);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleWrongCatet_NonRightTriangle_ReturnsException()
        {
            // Arrange
            var triangle = new Triangle(-3, 0, 5);
            var exptedMessage = "Area can't be negative or equal 0";

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.IsRightTriangle(), exptedMessage);
        }
    }
}
