// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for( int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
            Console.Write($"{result[i,j]}\t ");
        } 
        Console.WriteLine(); 
    }
     return result;
}
void PrintArray(int[,] arr, int m)
{
    //int count = 0;
    double sum = 0;
    for(int j = 0; j < arr.GetLength(1); j++)
   { 
        for(int i = 0; i < arr.GetLength(0); i++)
        {
        sum += arr[i,j];
        //count++;
        }
        double res = sum /m; //count;
        Console.Write("{0:0.0}\t" , res);
        //count = 0;
        sum = 0;
   } 
}
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение диапазона: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона: ");
int max = int.Parse(Console.ReadLine());
int[,]myArray= GetArray(m,n,min,max);
Console.WriteLine();
PrintArray( myArray, m);