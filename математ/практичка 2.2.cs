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
    // Определить время через n секунд без учёта факта перехода через сутки.
    DateTime currentTime = DateTime.Now; // получаем текущее время
int n = 3600; // количество секунд, на которое нужно сдвинуть время
DateTime newTime = currentTime.AddSeconds(n); // добавляем n секунд к текущему времени
Console.WriteLine("Новое время: " + newTime.ToString("HH:mm:ss")); // выводим новое время в формате часы:минуты:секунды
  }
}  