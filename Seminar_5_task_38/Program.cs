/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */


double [] CreateArray (int size, double min, double max) {
    
    double [] array = new double [size];
    Random rand = new Random();

    for (int i =0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(-100, 1001)*0.1, 1);

    }
    return array;
}

string Print (double [] array) {
    return string.Join("|", array);
}

double [] array = CreateArray(6, 10, 100);
Console.WriteLine($"Array is [{Print(array)}]");

(double MaxNum, double MinNum, double ProdNum) FindMaxMin (double [] array) {
    double max = 0;
    double min = -0;

    for (int i = 0; i < array.Length; i++)
    {
        max = array[i] < max ? max:array[i];
        min = array[i] > min ? min:array[i];      
    }
    return (MaxNum: max, MinNum: min, ProdNum: max-min);

} 

var tuple = FindMaxMin(array);
Console.WriteLine($"MaxDouble is: {tuple.MaxNum} ; MinDouble is {tuple.MinNum}; double subtraction is {tuple.ProdNum}");




    