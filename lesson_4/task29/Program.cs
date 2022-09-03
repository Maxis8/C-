// Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a,b) и выводит их на экран.

int[] IntArray(int num, int min, int max)
{   
    int[] arr = new int [num];
    for(int i=0; i<arr.Length; i++)
    { 
        
        arr[i] = new Random().Next(min, max);
    }
    return arr;    
 
}
 

Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение диапазона: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", IntArray(N , a, b)));
