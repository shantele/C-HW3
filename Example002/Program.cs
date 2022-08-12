// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A по оси oX: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A по оси oY: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A по оси oZ: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оси oX: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оси oY: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оси oZ: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(ax-bx,2)) + (Math.Pow(ay-by,2)) + (Math.Pow(az-bz,2)));
Console.WriteLine($"Расстояние в 3D пространстве: {Math.Round(distance,2)}");
