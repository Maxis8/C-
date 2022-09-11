// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1*x+b1, y = k2*x+b2;
// значения b1, k1, b2, k2 задаются пользователем.

string PointIntersection(double a1, double d1, double a2, double d2)
{
     double x=(d2-d1)/(a1-a2);
     
     double y=a1 *(d2-d1)/(a1-a2)+d1;
     string point = ($"{x}; {y}");
     return point;
}



Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PointIntersection(k1, b1, k2, b2));


// double PointIntersectionX(double a1, double d1, double a2, double d2)
// {
//     double x=(d2-d1)/(a1-a2);
    
//     return x;
// }
// double PointIntersectionY(double a1, double d1, double a2, double d2)
// {
     
    
     
//      double y= a1 *(d2-d1)/(a1-a2)+d1;
//      return y;
      
     
// }


// Console.WriteLine("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Точка пересечения прямых: x = {PointIntersectionX(k1, b1, k2, b2)}, ");
// Console.Write($" y = {PointIntersectionY(k1, b1, k2, b2)}");
// if((k1 * b2 - k2 *b1) == 0)Console.WriteLine(" Прямые не пересекаются");