﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] GetArray(int m, int n, int minValue, int maxValue )
{
  int num = 1;
  int[,] arr = new int[m,n];
  for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
        {
        
          while (num <= arr.GetLength(0) * arr.GetLength(1))
          {
           arr[i, j] = num;
           num++;
           if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
           j++;
           else if (i < j && i + j >= arr.GetLength(0) - 1)
           i++;
           else if (i >= j && i + j > arr.GetLength(1) - 1)
           j--;
           else
           i--;
          }
        }
    }
    return arr;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int[,] snakearray = GetArray(4,4,1,16);
PrintArray(snakearray);
  