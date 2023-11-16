// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNumbers(int n)
{
    if (n <= 1)
    {
        Console.Write($"{n}\t");
        return;
    }
    Console.Write($"{n}\t");
    PrintNumbers(n - 1);
}

int n = ReadInt("Введите натуральное число: ");
while (n < 1)
{
    Console.Write("Число не натуральное. ");
    n = ReadInt("Введите натуральное число: ");
}
PrintNumbers(n);
