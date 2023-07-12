// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = number / 10000;
int secondNumber = (number / 1000) % 10;
int fourthNumber = (number / 10) % 10;
int fiveNumber = (number % 10);

GetPolindrom(number);

bool GetPolindrom(int num)
{
    if (num < 0) num = Math.Abs(num);
    if (num / 100000 == 0 && num / 10000 != 0 && num / 1000 != 0 && num / 100 != 0 && num / 10 != 0)
    {

        if (firstNumber == fiveNumber && secondNumber == fourthNumber)
        {
            Console.WriteLine($"{num} -> да, полиндром");
        }
        else
            Console.WriteLine($"{num} -> нет, не полиндром");
    }
    else

        Console.WriteLine("Ошибка ввода");
        return Convert.ToBoolean(num);

}