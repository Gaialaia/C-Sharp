/*Урок 2. Базовые алгоритмы

Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int SecDigit(int number)

{
    number =  number / 10 % 10;
    return number;
}

Console.WriteLine("Input three digit number => ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SecDigit(number);
Console.WriteLine(result); 