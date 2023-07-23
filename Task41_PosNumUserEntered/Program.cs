// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("How many numbers you want to input?");
int size = Convert.ToInt32(Console.ReadLine());

int[] userEntered = CreateUserArray(size, -1000, 1000);
Console.WriteLine($"User entered next {size} numbers: ");
PrintArray(userEntered);

int positiveNumbers = PositiveNumbersEnteredUser(userEntered);
Console.WriteLine($"User entered {positiveNumbers} positive numbers.");

int[] CreateUserArray(int size, int min, int max) 
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} number");
        int element = Convert.ToInt32(Console.ReadLine());
        arr[i] = element;
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

int PositiveNumbersEnteredUser(int[] entered)
{
    int count = 0;
    for (int i = 0; i < entered.Length; i++)
    {
        if (entered[i] > 0) count += 1;
    }
    return count;
}