﻿/*Задача 60. ...Сформируйте двумерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
using System;
class MultiDemoArray {
static void Main () {
int [,,] nums = new int [2,2,2];

int [] arr = {1,2,3,4};

for (int i = 0; i < nums.GetLength(0); i++) {

    //Console.WriteLine("{0};", i+1);

for (int j = 0; j < nums.GetLength(1); j++){

for (int k = 0; k < nums.GetLength(2); k++) {
    nums [i,j,k] = arr [i];
    arr [i] ++;
    //Console.Write(nums [i,j,k]+" "); ({i},{j},{k})
    Console.Write($"{nums[i, j, k]} ({i},{j},{k}) ");
} 
Console.WriteLine(); 
}
}
}
} 

