// Задача 2: Напишите программу, которая принимает вход в координаты двух точек и нахождение расстояния между ними в 3D-пространствах.
// А (3,6,8); В (2,1,-7), -> 15,84
// А (7,-5, 0); В (1,-1,9) -> 11,53

int x1 = Coordinate("x", "A");
int b1 = Coordinate("b", "A");
int c1 = Coordinate("c", "A");
int x2 = Coordinate("x", "B");
int b2 = Coordinate("b", "B");
int c2 = Coordinate("c", "B");

int Coordinate(string coorname, string pointname)
{
    Console.Write($"Введите координату {coorname} точки {pointname}: ");
    return Convert.ToInt16(Console.ReadLine());
}

Double Decision(double x1, double x2,
                double b1, double b2,
                double c1, double c2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((b2 - b1), 2) +
                     Math.Pow((c2 - c1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, b1, b2, c1, c2), 2);

Console.WriteLine($"Длина отрезка  {segmentLength}");