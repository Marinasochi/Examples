// Деление
double Prompt(string message)
{
    System.Console.Write(message);    // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    double result = double.Parse(readValue);    // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

double numberA = Prompt("Введите numberA  ");
double numberB = Prompt("Введите numberB  ");
{
    Console.Write($"numberA / numberB = {numberA / numberB}");
}
