/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */


double [] CreateArray (int size, double min, double max) {
    
    double [] array = new double [size];
    Random rand = new Random();

    for (int i =0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(-100, 101)*0.1, 1);

    }
    return array;
}

string Print (double [] array) {
    return string.Join(",", array);
}

double [] array = CreateArray(6, 10, 100);
Console.WriteLine($"Array is [{Print(array)}]");




double max = array[0];
for(int i = 0; i < 6; ++i)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
Console.Write($"max digit is {max} ");

double min = array[0];
for(int i = 0; i < 6; ++i)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($" min digit is {min} ");


double ProductNum (double max, double min){
      double sum = max -min;
      return sum;
}

Console.WriteLine(ProductNum);
