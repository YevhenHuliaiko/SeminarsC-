// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

int reminder = IsMultiplicity(firstNum, secondNum);

// if (reminder == 0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Не кратно, остаток: {reminder}");

Console.WriteLine(reminder == 0 ? "Кратно" : $"Не кратно, остаток: {reminder}"); //тернарный оператор

int IsMultiplicity(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}