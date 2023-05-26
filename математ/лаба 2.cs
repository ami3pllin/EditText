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
    //12. Вводится один из символов строки цифр клавиатуры в английской раскладке.
    //Ответить названием символа.
    Console.WriteLine("Введите символ");
    char symbol = Console.ReadKey().KeyChar;
Console.WriteLine($"Название символа: {symbol}");


  }
} 