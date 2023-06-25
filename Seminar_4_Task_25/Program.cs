/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.WriteLine("Enter numberA ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numberB ");
int numberB = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Math.Pow(numberA, numberB));









/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

/*void FillArray (int [] collection )
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }

}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count);
    {   
        if (collection[index] == find) 
         {
            position = index;
           
    }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив из 10 элементов

FillArray(array);
array [4] = 4;
array [6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos); */



