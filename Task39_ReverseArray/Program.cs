// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; //1 значение первого элемента сохраняем
        arr[i] = arr[arr.Length - 1 - i]; // lenght-1 означает обращение к последнему элементу массива. -i означает обращение к симетричному, относительно меняемого элемента, правому элементу
        arr[arr.Length - 1 - i] = temp; // присваемаем правому элементу значение симетричного левого элемента
    }
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
ReverseArray(array);
PrintArray(array);

// Array.Reverse(array); //- встроенный метод поворота массива
// PrintArray(array);
