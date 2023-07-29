// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5    7     -2   -0,2
//  1   -3,3     8   -9,9
//  8    7,8   -7,1    9

double[,] CreateMatrixyRndDouble(int rows, int colums, int min, int max) // Для двумерного массива в сигнатуре указываются строки rows и столбцы colums.

{
    double[,] matrix = new double[rows, colums];        // Создали двумерный массив типа double заполненный нулями.

    Random rnd = new Random();                          //Создали объект Random.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min; // Метод получения случайного вещественного числа. Множитель для того что бы получать в требуемом диапазоне случайные числа.
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix, int round = 1) // Округление до одного знака
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = Math.Round(matrix[i, j], round); // Округление
            Console.Write($"{num,8}");
        }
        Console.WriteLine(" |");
    }
}

double[,] array2d = CreateMatrixyRndDouble(3, 4, -10, 10);
PrintMatrix(array2d);

