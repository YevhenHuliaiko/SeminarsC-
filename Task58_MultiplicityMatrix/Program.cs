
// Задача 58: Задайте две матрицы. Напишите программу, 
//             которая будет находить произведение двух матриц.
//             Например, даны 2 матрицы:
//             2 4 | 3 4
//             3 2 | 3 3
//             Результирующая матрица будет:
//             18 20
//             15 18



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

bool CheckForMultiplicity(int[,] firstMatrix, int[,] secondMatrix)
{
    return firstMatrix.GetLength(1) == secondMatrix.GetLength(0);
}

int[,] MatrixMultiplicity(int[,] firstMatr, int[,] secondMatr)
{
    int[,] multiplicityMatrix = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
    for (int i = 0; i < firstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatr.GetLength(1); j++)
        {
            multiplicityMatrix[i, j] = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                multiplicityMatrix[i, j] += firstMatr[i, k] * secondMatr[k, j];

            }
        }
    }
    return multiplicityMatrix;
}

int[,] firstMatrix = CreateMatrixyRndInt(2, 2, 1, 5);
PrintMatrix(firstMatrix);

int[,] secondMatrix = CreateMatrixyRndInt(2, 3, 1, 5);
Console.WriteLine();
PrintMatrix(secondMatrix);

if (!CheckForMultiplicity(firstMatrix, secondMatrix)) 
{
    Console.WriteLine("Невозможно перемножить матрицы!");
    return;
}

int[,] res = MatrixMultiplicity(firstMatrix, secondMatrix);

Console.WriteLine();
Console.WriteLine("Результирующая матрица будет равна:");
Console.WriteLine();
PrintMatrix(res);

