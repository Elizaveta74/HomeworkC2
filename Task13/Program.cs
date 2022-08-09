/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number/10;
    }
    int digit3 = number%10;

    Console.Write($"Третья цифра = {digit3}");
}
