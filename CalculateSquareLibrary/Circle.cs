namespace CalculateSquareLibrary;

// Фигура круг
public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Вычисляет площадь круга
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public double CalculateArea()
    {
        if (Radius <= 0)
        {
            throw new ArgumentException("Радиус окружности должен быть положительным");
        }
        return Math.PI * Radius * Radius;
    }
}