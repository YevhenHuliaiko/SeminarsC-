// Задача 8: Напишите программу, которая на вход принимает число (N),
//           а на выходе показывает все чётные числа от 1 до N.
//           5 -> 2, 4
//           8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Отсутствуют четные числа");
}
if (number <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    int counter = 2;
    Console.Write("Четные числа: ");
    while (counter <= number)

    {
        Console.Write(counter + " ");
        counter = counter + 2;
    }
}
