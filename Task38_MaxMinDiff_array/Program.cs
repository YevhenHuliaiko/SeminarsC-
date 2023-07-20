// Задача 38: Задайте массив вещественных чисел. 
//            Найдите разницу между максимальным и минимальным элементов массива.
//            [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] arrDouble = CreateArrayRndDouble(5, 0, 10);
PrintArray(arrDouble);

double findMaxElement = FindMaxElement(arrDouble);
//Console.WriteLine($"Максимальный элемент массива = {Math.Round(findMaxElement, 1)}");

double findMinElement = FindMinElement(arrDouble);
//Console.WriteLine($"Минимальный элемент массива = {Math.Round(findMinElement, 1)}");

double GetMaxMinDifference = MaxMinDifference(arrDouble);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(GetMaxMinDifference, 1)}");

double[] CreateArrayRndDouble(int size, int min, int max) // Это называется сигнатура метода 
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min; // Метод получения случайного вещественного числа. Множитель для того что бы получать в требуемом диапазоне случайные числа.
    }
    return arr;
}

void PrintArray(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round); // Округление
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }
    Console.WriteLine("]");
}

double FindMaxElement(double[] arr)
{
    double MaxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (MaxElement < arr[i]) MaxElement = arr[i];
    }
    return Math.Round(MaxElement, 1);
}

double FindMinElement(double[] arr)
{
    double MinElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (MinElement > arr[i]) MinElement = arr[i];
    }
    return Math.Round(MinElement, 1);
}

double MaxMinDifference(double[] arr)
{
    double diff = findMaxElement - findMinElement;
    return diff;
}