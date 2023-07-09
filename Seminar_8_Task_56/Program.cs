/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
 с наименьшей суммой элементов: 1 строка*/



void PrintArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    Console.Write($"{matr[i, j]} "); 
    }
    Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
 {
    for (int j = 0; j < matr.GetLength(1); j++) 
 {
    matr[i,j] = new Random().Next(1,10);
 }
 }
}


int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

int RowSum (int [,] arr, int i){
    int sum = arr [i,0];
        for (int j = 1; j < arr.GetLength(1); j++) {
            sum += arr [i,j];
    } 
    return sum;
}


int MinElSum = 1;
int sum = RowSum(matrix,0);
    for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (sum > RowSum(matrix,i))
{
{
    sum = RowSum(matrix,i);
    MinElSum = i +1;

}    
}
}
    Console.WriteLine();
    Console.WriteLine($"row {MinElSum}");
