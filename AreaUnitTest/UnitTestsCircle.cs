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
            var circle = new Circle(10);

            // Act
            var actualArea = circle.CalculateAreaFigure();

            // Assert
            Assert.AreEqual(314, actualArea);
        }

        [TestMethod]
        public void Circle_WithPositiveRadius_CreatesCircle()
        {
            // Arrange
            double radius = 10;

            // Act
            var circle = new Circle(radius);

            // Assert
            Assert.IsNotNull(circle);
        }
    }
}