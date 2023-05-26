using System;
class Hello {
  static void Main() {
    Console.WriteLine("Введите значение a");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Абсолютное значение: " + Math.Abs(a));
    Console.WriteLine("Введите значение b");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Максимальное значение" + Math.Max(a, b)); 
    double x = Convert.ToDouble(Math.Round(Math.Sqrt(a), 2));
    Console.WriteLine("Извлекаемый корень равен " + x); 
    //Кубашева Мария 12 Вариант
    //12. Вычислить гиперболический тангенс двумя способами, зная следующее соотношение:
    //tanh (x) = e^x-e^-x/e^+e^-x 
double c = 2.5;
double tanh1 = Math.Tanh(c); // первый способ
double tanh2 = (Math.Exp(c) - Math.Exp(-c)) / (Math.Exp(c) + Math.Exp(-c)); // второй способ
Console.WriteLine($"tanh({c}) = {tanh1} (первый способ)");
Console.WriteLine($"tanh({c}) = {tanh2} (второй способ)");
  }
}
