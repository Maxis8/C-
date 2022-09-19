// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[] SumArray(int[,] arr)
{
    int[] sumarray = new int[arr.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
            sumarray[i] = sum;
        }
        //Console.Write($"{minsum[i]} ");
        sum = 0;
    }
    return sumarray;
}
void MinSum(int[] minValue)
{
    int min = minValue[0];
    for (int i = 1; i < minValue.Length; i++)
    {
        if (minValue[i] < min) min = minValue[i];
    }
    Console.Write(min);
}
int[,] myArray = GetArray(4, 6, 0, 10);
PrintArray(myArray);
Console.WriteLine();
int[] sumArray = SumArray(myArray);
Console.WriteLine();
MinSum(sumArray);








