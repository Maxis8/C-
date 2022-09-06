// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.



 double[] GetArray(int size, int minValue, int maxValue)
{
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue) / 100.0   ;
        
    }
    return arr;

}

 double NumMax(double[] arr)
 {
    double max=arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        
        if(arr[i] > max) max = arr[i];
    }
    return max;
 }
 double NumMin(double[] arr)
 {
    double min =arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
 }
 
double[] printarray = GetArray(5, 0, 1000);
Console.WriteLine($"{String.Join(" ", (printarray))}");
double maxi = NumMax(printarray);
Console.WriteLine($"Максимальное число: {maxi}");
double mini = NumMin(printarray);
Console.WriteLine($"Минимальное число:  {mini}");
double result = maxi - mini;
Console.WriteLine($"Разница: {result}");



    

    