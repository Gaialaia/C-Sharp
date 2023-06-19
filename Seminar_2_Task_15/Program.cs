/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет  */


Console.WriteLine ("Enter number from 1 to 7  => ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("no");
        break;
    case 2:
        goto case 1;
    case 3:
        goto case 1;
    case 4:
        goto case 1;
    case 5:
        goto case 1;
    case 6:
        Console.WriteLine ("yes");
        break;
    case 7:
        goto case 6; 
}

/*Console.WriteLine ("Enter number from 1 to 7  => ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6 & number > 0)
{
    Console.Write ("No");
} 

if (number < 8 & number > 6)

{
    Console.Write ("Yes");
}

if (number >=8 )

{
    Console.Write ("No such weekday");
}
*/


// c методом не сработало
/*int Dayoff (int number)

{
    Console.WriteLine ("Enter number from 1 to 7  => ");

switch (number)
{
    case 1:
        Console.WriteLine("no");
        break;
    case 2:
        goto case 1;
    case 3:
        goto case 1;
    case 4:
        goto case 1;
    case 5:
        goto case 1;
    case 6:
        Console.WriteLine ("yes");
        break;
    case 7:
        goto case 6; 
}
}

int number = Convert.ToInt32(Console.ReadLine());
Dayoff(); */