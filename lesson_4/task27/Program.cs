// Напишите программу , которая принимает на вход число и выдаёт сумму цифр в числе.

int Numsum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{Numsum(num)}");

