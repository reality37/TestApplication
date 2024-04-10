namespace CalculateSquareLibrary;

// Фигура треугольник
public class Triangle : IShape
{
    private double FirstSide { get; }
    private double SecondSide { get; }
    private double ThirdSide { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Вычисляет площадь прямоугольника
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public double CalculateArea()
    {
        if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <=0)
        {
            throw new ArgumentException("Длины сторон треугольника должны быть положительными");
        }

        // Найдем полупериметр треугольника
        var p = (FirstSide + SecondSide + ThirdSide) / 2;

        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }

    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным
    /// </summary>
    /// <returns></returns>
    public bool IsRectangle()
    {
        return Math.Abs(FirstSide * FirstSide + SecondSide * SecondSide - ThirdSide * ThirdSide) < double.Epsilon;
    }
}