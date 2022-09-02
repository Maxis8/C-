// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Level(int num1, int num2)
{
    int result = 1;
    for(int i =1; i <= num2; i++)
    {
        result = result*num1;
    }
    return  result;
}    
 
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write($"{Level(number1, number2)}");
Console.WriteLine();
 
