// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.
//            [3, 7, 23, 12] -> 19
//            [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(5, 0, 10);
PrintArray(array);

int getSumEvenIndexElements = GetSumEvenIndexElements(array);
Console.WriteLine($"Сумма элементов стоящих на четных позициях = {getSumEvenIndexElements}");

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

int GetSumEvenIndexElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0 && i != 0) sum += arr[i];
        i++;
    }
    return sum;
}
