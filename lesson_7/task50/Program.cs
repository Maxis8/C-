//  Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void PrintArray(int[,] arr, int num)
{
    int count = 0;                             
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        { 
            
         if(arr[i,j] == num) 
         { 
             count++;
             Console.Write($"({i},{j})\t ");
             return;
         }

        }
        
    }
    if (count ==0) Console.WriteLine($"({num}) -> Такого числа в массиве нет");
   }
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение диапазона: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона: ");
int max = int.Parse(Console.ReadLine());
int[,]myArray= GetArray(m,n,min,max);
PrintArray( myArray, number);
