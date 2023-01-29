// Задача №17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

Console.Clear();

Console.Write("Enter X: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Enter Y: ");
int y = int.Parse(Console.ReadLine()!);

if (y > 0)
{
    if (x > 0)
    {
        Console.WriteLine("First period");
    }
    else
    {
        Console.WriteLine("Second period");
    }
}
else
{
    if (x > 0)
    {
        Console.WriteLine("Fourth period");
    }
    else
    {
        Console.WriteLine("Third period");
    }

}