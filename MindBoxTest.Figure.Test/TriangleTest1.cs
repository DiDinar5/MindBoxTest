using MindBoxTest.Figure.Shapes;

namespace MindBoxTest.Figure.Test
{
    public class TriangleTest1
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(8, 15, 17)]
        public void ValidTriangle(double a, double b, double c)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.True(area > 0);
        }

        [Theory]
        [InlineData(0, 1, 2)]   
        [InlineData(1, 0, 2)]
        [InlineData(1, 2, 0)]
        public void InvalidTriangle_ZeroSide(double a, double b, double c)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }


        [Fact]
        public void GetArea_ValidTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.Equal(6, area, precision: 5);
        }
    }
}