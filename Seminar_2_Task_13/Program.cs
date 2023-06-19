/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Enter number => ");
int number = Convert.ToInt32(Console.ReadLine());
//int result = 0;

if(number > 10000)
{
    Console.WriteLine(number / 100 % 10);
}
 
if (number > 1000 & number < 10000)
{
    Console.WriteLine (number / 10 % 10);
}

if (number < 100)
 {
    Console.Write ("there is no third number");
 }
 
if (number < 1000 & number > 100)
{
    Console.WriteLine (number % 10);
}