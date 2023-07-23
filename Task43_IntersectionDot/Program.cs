// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//             y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//             b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//             x = (b2-b1)/(k1-k2) 

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

double xCoordinate = FindCoordinate_X(b1, b2, k1, k2);
// Console.WriteLine($"X coordinate = {xCoordinate}");

double yCoordinate = FindCoordinate_Y(xCoordinate, b1, k1);
// Console.WriteLine($"Y coordinate = {yCoordinate}");

double intersectionDot = IntersectionDot(xCoordinate, yCoordinate);

double FindCoordinate_X(double b1, double b2, double k1, double k2)
{

    double xCoord = (b2 - b1) / (k1 - k2);
    return Math.Round(xCoord, 1);
}
double FindCoordinate_Y(double xCoordinate, double b1, double k1)
{

    double yCoord = k1 * x + b1;
    return Math.Round(yCoord, 1);
}

double IntersectionDot(double xCoordinate, double yCoordinat)
{
    Console.WriteLine($"Intersection Dot is : ({xCoordinate}, {yCoordinate})");
    return 0;
}