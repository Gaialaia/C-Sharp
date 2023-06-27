
/*Урок 5. Функции и одномерные массивы
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

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

int evenquan (int[] array) {
    int evenquan = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    evenquan = evenquan + 1;
    }
    return evenquan;
}

int [] array = CreateArray(7, 99, 999);
Console.WriteLine($"Array is [{Print(array)}]");

var tuple = evenquan(array);
Console.WriteLine($"Quantity of even numbers are:{evenquan(array)}");









/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */
