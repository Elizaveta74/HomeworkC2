/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine("Число трехзначное, можно продолжать.");

    int digit2 = (number/10)%10;

    Console.Write($"Вторая цифра = {digit2}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}



