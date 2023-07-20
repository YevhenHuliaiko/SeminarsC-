// Метод создания массива из вещественных чисел.


double[] arrDouble = CreateArrayRndDouble(5, -9, 9);
PrintArray(arrDouble);


double[] CreateArrayRndDouble(int size, int min, int max) // Это называется сигнатура метода 
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min; // Метод получения случайного вещественного числа. Множитель для того что быполучать в требуемом диапазоне случайные числа.
    }
    return arr;
}

void PrintArray(double[] arr, int round = 1) // "int round = 1" это опциональный параметр, округление до первого знака.
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