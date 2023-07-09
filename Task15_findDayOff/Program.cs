// Задача 15: Напишите программу, которая принимает на 
//            вход цифру, обозначающую день недели, и 
//            проверяет, является ли этот день выходным.
//            6 -> да
//            7 -> да
//            1 -> нет


Console.WriteLine("Введите цифру обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());

int day = DefineDayOff(number);

int DefineDayOff(int num)
{
    switch (number)
{
    case 1:
        Console.WriteLine("Этот день не является выходным");
        break;
    case 2:
        Console.WriteLine("Этот день не является выходным");
        break;
    case 3:
        Console.WriteLine("Этот день не является выходным");
        break;
    case 4:
        Console.WriteLine("Этот день не является выходным");
        break;
    case 5:
        Console.WriteLine("Этот день не является выходным");
        break;
    case 6:
        Console.WriteLine("Да, выходной");
        break;
    case 7:
        Console.WriteLine("Да, выходной");
        break;
    default:
        Console.WriteLine("Ошибка ввода");
        break;
}
return number;
}
