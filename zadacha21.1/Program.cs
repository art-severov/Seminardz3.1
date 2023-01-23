// Задача 21

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите координаты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты третьей точки ");
Console.Write("X3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1, y1, x2, y2, x3, y3 );
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanceRound}");


double Distance(int xc1, int yc1, int xc2, int yc2, int xc3, int yc3)
{
    return Math.Sqrt(Math.Pow((xc2 - xc1), 2) + Math.Pow((yc2 - yc1), 2) + Math.Pow((yc3-xc3), 2));
}