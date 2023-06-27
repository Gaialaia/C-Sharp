/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


int[] array = new int[8];

void FillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,9);
        index++;
    }
}


void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {   // ($"Our array => [{string.Join(",", array)}]");
        Console.Write($"[{string.Join(",",col)}]");
        position++;
    }

}

FillArray(array);
PrintArray(array);





