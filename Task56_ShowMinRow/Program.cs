// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//             которая будет находить строку с наименьшей суммой элементов.

//             Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             5 2 6 7
//             Программа считает сумму элементов в каждой строке и выдаёт номер 
//             строки с наименьшей суммой элементов: 1 строка


int rows = 4;
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

int[] SumRows(int[,] matrix)
{
    int[] sumRowElem = new int[matrix.GetLength(0)];
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            sumRowElem[k] = sum;
        }
        k++;
    }
    return sumRowElem;

}

int ShowMinRow(int[] sumRow)
{
    int minRowId = 0;
    int min = sumRow[0];
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (min > sumRow[i] && min != sumRow[i])
        {
            min = sumRow[i];
            minRowId = i + 1;
        }
    }
    
    return minRowId;

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

int[,] array2d = CreateMatrixyRndInt(rows, colums, 1, 9);
PrintMatrix(array2d);


Console.WriteLine();
int[] numRow = SumRows(array2d);
PrintArray(numRow);

int showMinRow = ShowMinRow(numRow);
Console.WriteLine($"Строка с наименьшей суммой элементов: {showMinRow} строка");

// Console.WriteLine(numRow);
// PrintMatrix(array2d);