// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int OddElementSum(int[] arr)
{
    int sum = 0;
    for(int i =0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum += arr[i];
    }
    return sum;
}


int[] printarray = GetArray(10, -10, 100);
Console.WriteLine($"{String.Join(" ", (printarray))}");
int summa = OddElementSum(printarray);
Console.WriteLine($"Сумма элементов на нечётных позициях: {summa}");