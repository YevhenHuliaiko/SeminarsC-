// Task37. Найдите произведения пар чисел в одномерном массиве
//          Парой считаем первый и последний элемент,
//          второй и предпоследний и т. д. Результат запишите в новом массиве.

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);

int[] getProductPairNumber = GetProductPairNumber(array);
PrintArray(getProductPairNumber);

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

int[] GetProductPairNumber(int[] arr)
{
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1; // Указали размер массива. Если в исходном мас четное количество элементов, тогда в результирующем мас будет в два раза меньше, иначе будет в два раза меньше + 1
    int[] product = new int[size];                                        // Создаем массив с указанным выше размером
    for (int i = 0; i < size; i++)
    {
        int prod = arr[i] * arr[arr.Length - i - 1];
        product[i] = prod;
    }
    if (arr.Length % 2 != 0) product[size - 1] = arr[arr.Length / 2]; // Если количество элементов мас не четно, то присваиваем последнему элементу нового массива средний элемент исходящего. Тоесть оставшийся, центральный элемент(без пары) ставим в конец нового мас.
    return product;
}

