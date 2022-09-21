//  Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int SumRec(int m, int n )
{
    if (m==n) return m; 
    return m += SumRec(m +1, n);
}

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = SumRec(num1, num2);
Console.WriteLine(sum);
