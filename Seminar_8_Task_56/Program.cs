/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
 с наименьшей суммой элементов: 1 строка*/



void PrintArray(int[,] matr)  //varialbe name!!!
{
 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    Console.Write($"{matr[i, j]} "); // filled with "0"
    }
    Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)  // getLength(0) - получить количество строк, rows or // i < 3
 {
 for (int j = 0; j < matr.GetLength(1); j++) //getLength(1) - получить количество columns or // j < 4
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }

}


int RowSum (int [,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        sum = sum += arr[i,j];
    }

}
}

int[,] matrix = new int[4, 4]; // variable name!!! new array

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
RowSum(matrix);
PrintArray(matrix);
