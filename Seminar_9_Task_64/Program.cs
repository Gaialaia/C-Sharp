/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Enter value1 ");
int value1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter value ");
int value2 = Int32.Parse(Console.ReadLine());

void Print (int value1, int value2) {
   
    if (value1 < value2) Print (value1 + 1, value2);
     Console.WriteLine (value1);
}
Print(value1, value2); 




/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/