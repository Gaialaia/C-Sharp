/*Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, 
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

//без метода:

/*int numcol = GetNumber("Enter column number ");
int numrow = GetNumber("Enter row number ");

int [,] array = CreateArray(3,4, -100, 100);
PrintArray(array);

if (numrow > array.GetLength(1) || numcol > array.GetLength(0))
{
    Console.WriteLine("Such element does not exist");
}
else
{
    Console.WriteLine($"Element is {array[numrow,numcol]}"); 
} */

int [,] CreateArray (int row, int col, int min, int max) {
    Random rand = new Random();
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = rand.Next(min, max +1);
        }
    } 
    return array;

} 


void PrintArray (int [,]array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
      for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i,j]}\t");
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.WriteLine();
    } 
}

int GetNumber (string description) { 

    int number; 
    Console.WriteLine($"{description} =>"); 

    while (true) 
    {
        string temp = Console.ReadLine(); 
        if(int.TryParse(temp, out number)) {  
            return number;
        }
                Console.Write($"This number \"{temp}\" is not correct. Try again =>");

    }


}

int [,] array = CreateArray(3,4, -100, 100);
PrintArray(array);

//метод
void CheckNum (int row, int col) {

    int numrow = GetNumber("Enter row number ");
    int numcol = GetNumber("Enter column number ");

    if (numrow > row && numcol > col) 
    {
        Console.WriteLine ("Element does not exist");
    }

    else
    {
    
    object CheckNum = array.GetValue(numcol,numrow);
    Console.WriteLine($" Number under this position is {CheckNum}");
}
}
CheckNum(3,4);






