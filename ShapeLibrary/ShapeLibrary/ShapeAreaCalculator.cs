namespace ShapeLibrary;

// Для вычисления площади фигуры без знания типа фигуры в compile-time
public class ShapeAreaCalculator
{
    public static double GetArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}