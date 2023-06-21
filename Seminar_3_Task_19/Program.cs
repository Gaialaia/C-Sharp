
﻿/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/ 


/*Console.WriteLine("Enter five digit number");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int number2 = number;
int number3 = number;
int number4 = number;
int number5 = number;


number1 = number / 10000 % 10;
Console.Write(number1);

number2 = number / 1000 % 10;
Console.Write(number2);

number3 = number / 100 % 10;
Console.Write(number3);

number4 = number / 10 % 10;
Console.Write(number4);

number5 = number / 1 % 10;
Console.Write(number5);

if (number1 == number5 & number2 == number4)
{
    Console.Write( " - number is a palindrome");
}

else
{
    Console.Write( " - number is not a palindrome");
} */

Console.WriteLine("Enter five digit number");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int number2 = number;
int number3 = number;
int number4 = number;
int number5 = number;

void Palindrome (int number) {

//Console.WriteLine("Enter five digit number");

number1 = number / 10000 % 10;
Console.Write(number1);

number2 = number / 1000 % 10;
Console.Write(number2);

number3 = number / 100 % 10;
Console.Write(number3);

number4 = number / 10 % 10;
Console.Write(number4);

number5 = number / 1 % 10;
Console.Write(number5);

if (number1 == number5 & number2 == number4)
{
    Console.Write( " - number is a palindrome");
}

else
{
    Console.Write( " - number is not a palindrome");
} 
}

Palindrome(number);

 