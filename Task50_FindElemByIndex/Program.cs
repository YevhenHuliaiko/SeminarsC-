// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

void FindingElementByIndexes(int[,] matrix)
{
    Console.WriteLine("Введите позицию элемента в строке: ");
    int indexI = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите позицию элемента в cтолбце: ");
    int indexJ = Convert.ToInt32(Console.ReadLine());
    int res = 0;

    if (indexI > matrix.GetLength(0) && indexJ > matrix.GetLength(1))
        Console.WriteLine("Такого элемента в массиве нет.");

    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                res = matrix[indexI, indexJ];
            }
        }
        Console.WriteLine($"Значение заданого элемента = {res}");
    }
}

int[,] array2d = CreateMatrixyRndInt(3, 4, -10, 10);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
FindingElementByIndexes(array2d);


