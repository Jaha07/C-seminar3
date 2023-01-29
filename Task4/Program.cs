// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N


Console.Clear();
Console.Write("Enter any number: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1;
// Console.Write($"{Math.Pow(count, 2)}");
// count++;

while (count <= number)
{
    // double result = Math.Pow(count++, 2);
    Console.Write($"{Math.Pow(count, 2)}");
    if (count != number) Console.Write(", ");
    count++;
}