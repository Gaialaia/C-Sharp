/*Урок 6. Одномерные массивы. Продолжение
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */





int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result; 
}

int [] InputArray (int length) {
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt ($"Insert {i+1} element");
    }
    return array;
}

void PrintArray (int [] array) {
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers (int [] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        count ++;
    }

    return count;


}

int length = Prompt ("Insert element quantity => ");
int[,] array;
array = InputArray(length);
//PrintArray(array);
Console.WriteLine($"Quantity of numbers < 0 {CountPositiveNumbers(array)}");


/*Console.WriteLine("Введите число");

string number = Console.ReadLine();

for (int i = 0; i < 3;)

{   int count=0; 
    
    Console.WriteLine("Введите число");
    Console.ReadLine();
    i ++;
    count++;;
    Console.WriteLine($"{count}");
    
} */



/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})"); */
