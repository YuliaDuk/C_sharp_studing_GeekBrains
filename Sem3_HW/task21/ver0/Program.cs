// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х1:");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z1:");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X2:");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z2:");
double Z2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2-Z1), 2));
Console.WriteLine($"Расстояние между точками равно {length}");