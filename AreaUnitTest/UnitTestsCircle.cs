using CalculateArea;

namespace AreaUnitTest
{
    [TestClass]
    public class UnitTestsCircle
    {
        [TestMethod]
        public void CalculateArea_CircleWithСorrectRadius_CorrectArea()
        {
            // Arrange
            var circle = new Circle(10.0);

            // Act
            var actualArea = circle.CalculateAreaFigure();
            var expectedArea = Math.PI * 10 * 10;
            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_CircleWitheNegativeParam_ReturnCalculateAreaFigureExeption()
        {
            // Arrange
            var radius = new Circle(-10.0);
            var exptedMessage = "Area can't be negative or equal 0";

            // Act
            var resutl = radius.CalculateAreaFigure();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => radius.CalculateAreaFigure(), exptedMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeRadius_IsInValidAria_ReturnException()
        {
            // Arrange
            var radius = new Circle(-10.0);
            var exptedMessage = "Area can't be negative or equal 0";

            // Act
            radius.IsValidParam();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => radius.IsValidParam(), exptedMessage);
        }
    }
}