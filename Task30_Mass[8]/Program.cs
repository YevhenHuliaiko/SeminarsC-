
//                            //0 1 2 3 4 5 6 7
// int[] array = new int[8]; //0 0 0 0 0 0 0 0
// int[] array = { 3, 65, -35, 6, 7, 8 };

// int[] array2 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

// var array4 = new int[8];

// array[0] = 4545;
// array[7] = 4555;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }



// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        //arr[i] = new Random().Next(2); //2 потому что не включительно 2, тоесть от 0  до 1
        arr[i] = rnd.Next(2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

}