// Программа которая на вход принимае целое число N, а на выходе выдает все целые числа
// от -N до N

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) 
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    int counter = -number;
    while (counter <= number)
    {
        Console.Write(counter + " ");
        counter = counter + 1;

    }
}