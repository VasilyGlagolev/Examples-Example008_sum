// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool isThreeDigit;

        do
        {
            Console.Write("Введите трёхзначное число: ");
            number = int.Parse(Console.ReadLine());

            isThreeDigit = (number >= -999 && number <= -100) || (number >= 100 && number <= 999);

            if (!isThreeDigit)
            {
                Console.WriteLine("Ошибка ввода! Введите трехзначное число.");
            }

        } while (!isThreeDigit);

        int secondDigit = Math.Abs(number / 10) % 10;

        Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
    }
}
