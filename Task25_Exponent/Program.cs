// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//            и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) numberB *= (-1);

int exponent = Exponent(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {exponent}");

int Exponent(int numA, int numB)
{
    int res = 1;
    for (int i = 0; i < numB; i++)
    {
        res *= numA;

    }
    return res;
}