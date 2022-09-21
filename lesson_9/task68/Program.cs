// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine("Введите m: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int num2 = int.Parse(Console.ReadLine());
int akkernum = Akkerman(num1, num2);
Console.Write($"Функция Аккермана = {akkernum} ");