namespace CalculateSquareLibrary;

public static class CalculateSquareHelper
{
    /// <summary>
    /// Вычисляет площадь фигуры
    /// </summary>
    /// <param name="shape">Фигура, площадь которой необходимо рассчитать</param>
    /// <returns></returns>
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}