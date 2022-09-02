// Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a,b) и выводит их на экран.



int[] IntArray()
{    
    int[] arr = new int [12];
    for(int i=0; i<arr.Length; i++)
    { 
        arr[i] = new Random().Next(0, 35);
        
    }
    return arr;    
 
}
 



Console.WriteLine(String.Join(", ", IntArray()));

