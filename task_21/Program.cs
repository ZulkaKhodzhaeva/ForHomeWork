// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты первой точки x1: ");
int firstx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки y1: ");
int firsty = int.Parse(Console.ReadLine());
Console.Write("Введите координаты третьей точки, z1: ");
int firstz = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй точки, x2: ");
int secondx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй точки, y2: ");
int secondy = int.Parse(Console.ReadLine());
Console.Write("Введите координаты третьей точки, z2: ");
int secondz = int.Parse(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(firstx - secondx, 2) + Math.Pow(firsty - secondy, 2) + Math.Pow(firstz - secondz, 2));
Console.WriteLine();
Console.WriteLine($"Расстояние между точками ({firstx};{firsty};{firstx}) и ({secondx};{secondy};{secondz}) составляет {distance:f2}");
