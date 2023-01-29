// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();

Console.Write("Enter period: ");
int coordinate = int.Parse(Console.ReadLine()!);

if (coordinate > 2)
{
    System.Console.WriteLine("Coordinate Y < 0");
}
else
{
    System.Console.WriteLine("Coordinate Y > 0");
}

if (coordinate == 1 || coordinate == 4)
{
    System.Console.WriteLine("Coordinate X > 0");
}
else
{
    System.Console.WriteLine("Coordinate X < 0");
}
