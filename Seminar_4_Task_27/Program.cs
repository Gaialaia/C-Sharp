/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetNumber (string description) {  // получаем целое число

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


int GetSum (int number) {
    int sum = 0;
    while (number!=0)
    {
        sum += number%10;
        number /= 10;
    }
    return sum;
}

int number = GetNumber("Enter number ");
Console.WriteLine($"Sum of digits in {number} is {GetSum(number)}");


