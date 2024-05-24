// See https://aka.ms/new-console-template for more information
using ShapeCalcConsole;
using ShapeCalcLib;


List<IShape> shapes = new List<IShape>
        {
            new Circle(3),
            new Triangle(3, 4, 5),
            new CustomShape()
        };


Console.WriteLine($"Треугольник прямоугольный: {((Triangle)shapes[1]).IsRightAngled()}");

foreach (IShape shape in shapes)
{
    Console.WriteLine($"Площадь фигуры: {shape.GetShapeArea()}");
}