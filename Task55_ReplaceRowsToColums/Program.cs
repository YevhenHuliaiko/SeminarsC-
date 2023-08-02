// Задача 55: Задайте двумерный массив. Напишите программу,
//              которая заменяет строки на столбцы. В случае, если это
//              невозможно, программа должна вывести сообщение для
//              пользователя.

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

void ReplaceRowsToColums(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

bool CheckSquareMatrix(int[,] matrix)  // Метод проверки матрицы на квадратность
{
    return matrix.GetLength(0) == matrix.GetLength(1); // Проверка матрицы на квадратность
}

int[,] array2d = CreateMatrixyRndInt(4, 4, 1, 9);
if (!CheckSquareMatrix(array2d)) // Если матрица НЕ квадратная, выводим соответствующее сообщение
{
    Console.WriteLine("Матрица не квадратная, невозможно заменить строки на столбцы");
    return;
}

PrintMatrix(array2d);
Console.WriteLine();
ReplaceRowsToColums(array2d);
PrintMatrix(array2d);