// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.
//            [345, 897, 568, 234] -> 2

int[] array = CreateArrayRndInt(5, 100, 999);
PrintArray(array);

int getCountEvenNumbers = GetCountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {getCountEvenNumbers}");

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

int GetCountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}