
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c = int.Parse(Console.ReadLine());

if (b < a && a > c)
{
    Console.Write(a);
}
else if (a < b && b > c)
{
    Console.Write(b);
}
else
{
    Console.Write(c);
}


