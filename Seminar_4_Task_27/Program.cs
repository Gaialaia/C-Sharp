/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

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


int GetSum (int number) {
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int number = GetNumber("Enter number ");
Console.WriteLine($"Sum of digits in {number} is {GetSum(number)}");


