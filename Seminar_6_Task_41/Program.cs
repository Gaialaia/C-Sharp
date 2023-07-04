/*Урок 6. Одномерные массивы. Продолжение
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */



Console.WriteLine("Введите число");

string number = Console.ReadLine();

for (int i = 0; i < 3;)

{   int count=0; 
    
    Console.WriteLine("Введите число");
    Console.ReadLine();
    i ++;
    count++;;
    Console.WriteLine($"{count}");
    
}




/*int GetNumber (string description) { 

    int number; // inizilisation
    Console.WriteLine($"{description} =>"); //форматированный вывод

    while (true) 
    {
        string temp = Console.ReadLine(); // получаем строку с консоли и далее с этой строкой нужно что-то делать
        if(int.TryParse(temp, out number)) {  // конвертация числа из строки
            return number;
        }
                Console.Write($"This number \"{temp}\" is not correct. Try again =>");

    }

}

int n = GetNumber("Enter number ");

int [] CreateArray (int size, int min, int max) {
    
    int [] array = new int [size];
    Random rand = new Random();

    for (int i =0; i < size; i++)
    {
        array[i] = rand.Next (min, max + 1);

    }
    return array;

}

int [] array = CreateArray(10, 0, 11);
Console.WriteLine($"[{string.Join(",",array)}]");


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/



