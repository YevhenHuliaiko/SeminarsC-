
// Задача 51. Задайте двумерный массив.Найдите сумму элементов, находящихся на главной диагонали
//             (с индексами (0,0); (1,1) и т. д.).

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

int SumElementsMainDiagonale(int[,] matrix)
{
    int sumDiagElem = 0;
    // int size = matrix.GetLength(0); // (1) Условия для оптимизации программы
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1); // (1) словия для оптимизации программы

    // for (int i = 0; i < size; i++) // (1) Условия для оптимизации программы
    for (int i = 0; i < matrix.GetLength(0) && i<matrix.GetLength(1); i++)
    {
        // for (int j = 0; j < matrix.GetLength(1); j++)
        // {
        //     if (i == j) sumDiagElem += matrix[i, j];
        // }

        sumDiagElem += matrix[i, i];
    }
    return sumDiagElem;
}

int[,] array2d = CreateMatrixyRndInt(4, 3, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();

int sumElements = SumElementsMainDiagonale(array2d);
Console.WriteLine($"Сумма элементов главной диагонали = {sumElements}");