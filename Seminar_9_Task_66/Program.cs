/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Enter el1:");
int el1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter el2: ");
int el2 = Convert.ToInt32(Console.ReadLine()); 

int SumEl(int el1, int el2) {
    if (el1 == el2)
    return el2;;

    if (el2 < el1)
    return  el1 + SumEl(el1 - 1, el2);
    else return el1+ SumEl(el1 + 1, el2);
    }
    Console.WriteLine($"{SumEl(el1,el2)}");