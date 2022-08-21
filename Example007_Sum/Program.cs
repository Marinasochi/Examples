// Сумма двух чисел
int Prompt(string message)
{
     Console.Write(message);           // Вывести сообщение
     string readValue = Console.ReadLine();   // Считывает с консоли строку
     int result = int.Parse(readValue);    // Преобразует строку в целое число
     return result;                           // Возвращает результат функции  }
}

int numberA = Prompt("Введите число A ");
int numberB = Prompt("Введите число B ");

{
    Console.WriteLine(numberA + numberB);
}