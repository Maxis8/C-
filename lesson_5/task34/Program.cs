// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] GetArray(int size, int minValue, int maxValue)
{ 
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    { 
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;

}

int Even(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++ )
    {
        
        if(arr[i] % 2 == 0) count++; 
    }
    return count;
}

int[] printarray = GetArray(10, 100, 1000);
Console.WriteLine($"{ String.Join(" ",(printarray))}");
int result = Even(printarray);
Console.WriteLine($"Количество чётных чисел: {result} ");