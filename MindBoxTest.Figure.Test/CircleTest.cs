using MindBoxTest.Figure.Shapes;

namespace MindBoxTest.Figure.Test
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ValidCircle(double radius)
        {
            // Arrange & Act
            var circle = new Circle(radius);

            // Assert
            Assert.Equal(radius, circle.Radius);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        public void InvalidCircle_NonPositiveRadius(double radius)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Fact]
        public void GetArea_ValidCircle()
        {
            // Arrange
            var radius = 3;
            var circle = new Circle(radius);

            // Act
            var area = circle.GetArea();

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
        }
    }
}
