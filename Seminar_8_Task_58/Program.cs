/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/



int[,] Matrix1 = new int[2, 2];
CreateArray(Matrix1);
Console.WriteLine($"\nMatrix1 is :");
PrintArray(Matrix1);

int[,] Matrix2 = new int[2, 2];
CreateArray(Matrix2);
Console.WriteLine($"\nMatrix2 is :");
PrintArray(Matrix2);

int[,] product = new int[2,2];

MultiplyMatrix(Matrix1, Matrix2, product);
Console.WriteLine($"\nThe matrix product is :");
PrintArray(product);

void MultiplyMatrix(int[,] Matrix1, int[,] Matrix2, int[,] product)
{
  for (int i = 0; i < product.GetLength(0); i++)
  {
    for (int j = 0; j < product.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < product.GetLength(1); k++)
      {
        sum += Matrix1[i,k] * Matrix2[k,j];
      }
      product[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,9);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}