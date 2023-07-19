// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetDigitsSum(number);
Console.WriteLine($"Сумма чисел числа равна {result}");

int GetDigitsSum(int num)
{

    int sum = 0;
    int counter = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        counter++;
        num = num/10;
    }
    return sum;
}
