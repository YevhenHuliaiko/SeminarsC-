// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int res = ShowSecondNumber(number);

if (number<0)
res=res*(-1);

Console.WriteLine($"Вторая цивра числа: {res}");

int ShowSecondNumber(int num)
{
    int firstDigit = num / 10;
    int secondDigit = firstDigit % 10;
    return secondDigit;

}