/*Урок 8. Двумерные массивы. Продолжение
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


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


void ArraySort (int [,] mat) {
    for (int i = 0; i < mat.GetLength(0);i++)
        for (int j = 0; j < mat.GetLength(1); j++)
            for (int k = 0; k < mat.GetLength(1); k++)
            {
                if (mat[i,j] <= mat [i,k]) continue;
                int temp = mat [i,j];
                mat [i,j] = mat [i,k];
                mat [i,k] = temp; 
            }
        
}

int[,] matrix = new int[3, 4]; 

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ArraySort(matrix);
PrintArray(matrix);
