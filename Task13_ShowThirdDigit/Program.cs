// Задача 13: Напишите программу, которая выводит третью цифру 
//            заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0 || number / 10 == 0)
{
    Console.WriteLine($"Третьей цифры у числа {number} нет");
}
else
{
    if (number < 0)
{
    number = Math.Abs(number);
}
    int res = ShowThirdDigit(number);
    Console.WriteLine($"Третья цифра числа : {res}");

    int ShowThirdDigit(int num)
    {

        int divNum = num;

        while (divNum / 1000 > 0)
        {
            divNum = num / 10;
            num = num / 10;
        }

        int result = divNum % 10;
        return result;
    }
}

