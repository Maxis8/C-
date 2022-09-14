//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] GetArray(int m, int n)
{
    double[,] array = new double[m,n];
    for(int i =0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble( )* 100;
        }
    }
    return array;
}
void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        { 
            Console.Write("{0:0.00}\t" , arr[i,j] );
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray= GetArray(m,n);
Console.WriteLine();
PrintArray(myArray);