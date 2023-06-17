// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int summa (int a, int b)
{
    if (a == b)
        return b;
    else if (b > a) 
        return summa (a, b-1) + b;
    return summa (a-1, b) + a;
}


Console.Clear();
Console.Write("Введите 1 число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(summa (n, m));