// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GeterArray(int m, int n, int minValue, int maxValue)
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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue );
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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] MultiMatrix(int[,] arr, int[,] array)
        {
            int[,] matrix = new int[arr.GetLength(0), array.GetLength(1)];
 
            for (int i = 0; i < arr.GetLength(0); ++i)
            { 
                for (int j = 0; j < array.GetLength(1); ++j)
                { 
                    for (int k = 0; k < array.GetLength(0); ++k)
                    { 
                        matrix[i, j] += arr[i, k] * array[k, j];
                        
                    }
                }
            }
            return matrix;
        }
         
int[,] myArray = GetArray(2, 2, 2, 10);
int[,] twoArray = GeterArray(2, 2, 2, 10);
int[,] newArray =new int[myArray.GetLength(0), twoArray.GetLength(1)];
PrintArray(myArray);
Console.WriteLine();
PrintArray(twoArray);
Console.WriteLine();
Console.WriteLine();
PrintArray(MultiMatrix(myArray, twoArray));

   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   

 
        
        
            
        
    





