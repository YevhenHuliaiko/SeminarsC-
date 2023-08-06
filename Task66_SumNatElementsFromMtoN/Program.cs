// Задача 66: Задайте значения M и N. Напишите программу, 
//             которая найдёт сумму натуральных элементов в промежутке от M до N.
//             M = 1; N = 15 -> 120
//             M = 4; N = 8. -> 30

Console.WriteLine();
Console.WriteLine();
Console.Write("Введите натуральное значение M: ");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());

int SumElements(int m, int n)
{
    if (m == n)
        return n;
    else if (m < n)
    {
        return m + SumElements(m + 1, n);
    }
    else
    {
        return n + SumElements(n + 1, m);
    }
}

bool CheckNatural(int valueM, int valueN)
{
    return valueM > 0 && valueN > 0;
}

if (!CheckNatural(valueM, valueN))
{
    if (valueM < 0 && valueN < 0)
    {
        Console.WriteLine("Введенные M и N не натуральные. Невозможно выполнить программу!");
    }
    else if (valueN < 0)
    {
        Console.WriteLine("Введенное число N не натуральное. Невозможно выполнить программу!");
    }
    else
    { Console.WriteLine("Введенное число M не натуральное. Невозможно выполнить программу!"); }
    return;
}


int res = SumElements(valueM, valueN);
Console.Write($"Сумма натуральных элементов от М до N: ");
Console.WriteLine(res);
Console.WriteLine();


