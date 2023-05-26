using System;
class Hello {
  static void Main() {
   
    //Кубашева Мария 12 Вариант
    //вычислить Z=a^2+cos(a)/a-tg(√a^2+b)
//Где a = {cos(b) при b>5
//{b^2-b*√b при b≤5
//b={m при m>n
//{m^2*n при m≤n
double a, b, Z;
if (n <= 0) //проверка на корректность входных данных
{
    Console.WriteLine("Ошибка: n должно быть положительным числом");
}
else
{
    if (m > n)
    {
        b = m;
    }
    else
    {
        b = Math.Pow(m, 2) * n;
    }
    if (b > 5)
    {
        a = Math.Cos(b);
    }
    else
    {
        a = Math.Pow(b, 2) - b * Math.Sqrt(b);
    }
    Z = Math.Pow(a, 2) + Math.Cos(a) / a - Math.Tan(Math.Sqrt(Math.Pow(a, 2) + b));
    Console.WriteLine("Z = " + Z);
   }
  }   
}
