using System;
namespace MyProgram
{
  // Вывод размера экрана и буфера консоли
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Работа с консолью";
      Console.WriteLine("BufferWidth : " + Console.BufferWidth);
      Console.WriteLine("BufferHeight: " + Console.BufferHeight);
      Console.WriteLine("WindowWidth : " + Console.WindowWidth);
      Console.WriteLine("WindowHeight: " + Console.WindowWidth);
      Console.ReadKey();
    }
  }
}
