// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//             арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int rows = 3;
int colums = 4;

int[,] CreateMatrixyRndInt(int rows, int colums, int min, int max) // Для двумерного массива в сигнатуре указываются строки rows и столбцы colums.

{
    int[,] matrix = new int[rows, colums];              // Создали двумерный массив заполненный нулями. rows=3, colums=4.

    Random rnd = new Random();                          //Создали объект Random.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);       // +1 потому что в методе Next интервал не включен

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

double[] FindingAverageColums(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arr[j] = (double)sum / (double)matrix.GetLength(0);
    }
    return arr;
}

void PrintArray(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round); // Округление
        if (i < arr.Length - 1) Console.Write($"{num}; ");
        else Console.Write($"{num}");
    }
    Console.WriteLine("]");
}

int[,] array2d = CreateMatrixyRndInt(rows, colums, -10, 10);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
double[] result = FindingAverageColums(array2d);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray(result);