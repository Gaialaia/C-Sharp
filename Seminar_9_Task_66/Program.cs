/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Enter value1 ");
int value1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter value ");
int value2 = Int32.Parse(Console.ReadLine());

void Print (int value1, int value2) {
   
    if (value1 < value2) Print (value1 + 1, value2);
     Console.WriteLine (value1);
}
Print(value1, value2); 

