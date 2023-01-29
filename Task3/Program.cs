// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

Console.Clear();

Console.Write("Enter x1 coordinate: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter y1 coordinate: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Enter x2 coordinate: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter y2 coordinate: ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));
// result = Math.Round(result, 3);
Console.WriteLine($"Distance between two points is {result:F3}");

