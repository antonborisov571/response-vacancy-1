using ShapeLibrary;

namespace ShapeTests;

public class ShapeTests
{
    [Fact]
    public void CircleAreaTest()
    {
        // Arrange
        Circle circle = new Circle(5);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * 25, area, 10);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area, 10);
    }

    [Fact]
    public void IsRightTriangleTest()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRight);
    }

    [Fact]
    public void IsNotRightTriangleTest()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 6);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.False(isRight);
    }

    [Fact]
    public void InvalidCircleTest()
    {
        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void InvalidTriangleTest()
    {
        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
    }
}