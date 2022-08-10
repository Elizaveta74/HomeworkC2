/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("No, this is not your day off, it's a working day.");
        break;
    case 2:
        Console.WriteLine("No, this is not your day off, it's a working day.");
        break;
    case 3:
        Console.WriteLine("No, this is not your day off, it's a working day.");
        break;
    case 4:
        Console.WriteLine("No, this is not your day off, it's a working day.");
        break;
    case 5:
        Console.WriteLine("No, this is not your day off, it's a working day.");
        break;
    case 6:
        Console.WriteLine("Yes, this is your day off - Saturday!");
        break;
    case 7:
        Console.WriteLine("Yes, this is your day off - Sunday!");
        break;
    default:
        Console.WriteLine("There is no number like that. Try again.");
        break;
}

