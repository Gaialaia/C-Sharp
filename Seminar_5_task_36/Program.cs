/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] CreateArray (int size, int min, int max) {
    
    int [] array = new int [size];
    Random rand = new Random();

    for (int i =0; i < size; i++)
    {
        array[i] = rand.Next (min, max + 1);

    }
    return array;

}

string Print (int [] array) {
    return string.Join(",", array);
}

int OddSum (int [] array) {

    int sum = 0;
    int i = 1;
    
    while (i < array.Length) 
    {
    sum = sum + array[i];
    i = i + 2;
    }
    return sum;
}
int [] array = CreateArray(6, 1, 9);
Console.WriteLine($"Array is [{Print(array)}]");

var tuple = OddSum(array);
Console.WriteLine($"Sum of elements in odd positions are:{OddSum(array)}");
