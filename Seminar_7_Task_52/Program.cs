/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int row = 3;
int col = 4;
int[,] array = new int[row,col];

void MakeArray (int row, int col){
    int i,j;
    Random rand = new Random();
    for (i = 0; i < row; i++)
    {
    Console.WriteLine();
    for (j = 0; j < col; j++)
    {
    array[i,j] = rand.Next(1,9);
    Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
    }
 }

void ArithMean(int row, int col) {
int i,j;

    for (j = 0; j < col; j++)
    {
    double sum = 0;
    for (i = 0; i < row; i++)
    {
    sum = sum + array[i,j];
    }
    Console.Write($"{sum/(i)}\t");
    }
 }

MakeArray(row,col);
Console.WriteLine();
ArithMean(row,col);

