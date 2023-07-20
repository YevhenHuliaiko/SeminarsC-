// Task 31. Задайте массив из 12 ти элементов, заполненный случайными числами из промежутка [-9,9].
//          Найти сумму отрицательный и положительных элементов массива.


int[] CreateArrayRndInt(int size, int min, int max) // Это называется сигнатура метода 
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); // +1 потому что в методе Next интервал не включен
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int SumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] SumPositiveNegativeElem(int[] arr)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            SumPositive += arr[i];
        }
        else
        {
            SumNegative += arr[i];
        }
    }
    return new int[]{SumPositive, SumNegative};
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

int sumPositiveElem = SumPositiveElem(array);
int sumNegativeElem = SumNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");

int[] sumPositiveNegativeElem = SumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");