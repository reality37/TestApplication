using CalculateSquareLibrary;

var circle = new Circle(10);
var triangle = new Triangle(4, 3, 5);

var circleSquare = CalculateSquareHelper.CalculateArea(circle);
var triangleSquare = CalculateSquareHelper.CalculateArea(triangle);

Console.WriteLine($"Площадь круга равна: {circleSquare}");
Console.WriteLine($"Площадь треугольника равна: {triangleSquare}");

Console.WriteLine($"Треугольник является прямоугольным? {triangle.IsRectangle()}");
Console.WriteLine("Test");
