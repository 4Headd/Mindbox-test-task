using MindBoxTestCase.Interfaces;
using MindBoxTestCase.Models;
using MindBoxTestCase.Services;
/*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
 * Дополнительно к работоспособности оценим:
 * Юнит-тесты
 * Легкость добавления других фигур
 * Вычисление площади фигуры без знания типа фигуры в compile-time
 * Проверку на то, является ли треугольник прямоугольным
*/

Console.WriteLine("The area of triangle with sides 3, 4, 5 is " + Figure.CalculateTriangleArea(3, 4, 5));
Console.WriteLine("The triangle with sides 3, 4, 5 is" + (Figure.IsRightTriangle(3, 4, 5) ? " right triangle" : " not right triangle"));

Console.WriteLine();

Console.WriteLine("The area of triangle with sides 2, 3, 4 is " + Figure.CalculateTriangleArea(2, 3, 4));
Console.WriteLine("The triangle with sides 2, 3, 4 is" + (Figure.IsRightTriangle(2, 3, 4) ? " right triangle" : " not right triangle"));

Console.WriteLine();

Console.WriteLine("The area of circle with radius of 4 equals " + Figure.CalculateCircleArea(4));

// Интерфейс объединяет все классы-фигуры функционалом - вычислением площади.
IFigure figure = new Circle(3);

Console.WriteLine(figure.CalculateArea());
Console.WriteLine(Figure.CalculateArea(figure));
