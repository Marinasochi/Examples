void Method1() // вывод в консоль фиксированного текста
{
    Console.WriteLine("MarinaMyazina");
}
//Method1();

void Method2(string msg)  // вывод в консоль указанного в вызываемом методе текста
{
    Console.WriteLine(msg);
}
//Method2("Marina");

void Method21(string msg,int count) //  вывод в консоль указанного в вызываемом методе текста указанное кол-во раз
{
    int i=0;
    while(i<count)
    {
    Console.WriteLine(msg);
    Console.ReadLine();
    i++;
    }
}
//Method21("Введите сообщение  ", 4);

int Method3() //  выводит в консоль и возвращает в виде целого числа текущий год
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

string Method4(int count, string text) // выводит в консоль и возвращает в виде строки указанный
{                                      // текст указанное количество раз
    string result = string.Empty;
    int i = 0;
    while(i < count)
    {
        result += text;
        i++;
    }
    return result;
}
//string res = Method4(10, "UriParser!!"!);
//Console.WriteLine(res);

//for(int i = 2; i < 11; i++) // цикл в цикле. Выводит в консоль таблицу умножения
{
    for(int j = 1; j < 11; j++)
    {
      //  Console.Write($"{j}x{i} = {i*j}  ");
    }
//Console.WriteLine("");
}

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "  
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + "Вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue) // правка b возврат текста в виде строки
{                                                        // при вызове метода задается текст в виде строки, 
    string result = string.Empty;                        // также заменяемый и заменяющий символы типом char
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
    if(text[i] == oldValue) result += $"{newValue}";
    else result += $"{text[i]}";
    }
    return result;
}            
//string newtext = Replace(text, ' ',  '–');
//Console.WriteLine(newtext);
string tex = new string('*',40);
//Console.WriteLine(tex);
//newtext = Replace(newtext,'к', 'К');
//Console.WriteLine(newtext);
//Console.WriteLine(tex);
//newtext = Replace(newtext, 'с', 'С');
//Console.WriteLine(newtext);
//Console.WriteLine(tex);

int[] arr = {8, 9, 6, 78, 10, -9};

void ArrayPrint(int[] array) // вывод массива в консоль
{
    int count = array.Length;
    for(int i=0; i < count; i++ )
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine($"\n{tex}");
}

void Collect(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {   
        int max = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[max]) max = j;   
        }    
        int temp = array[i]; array[i] = array[max]; array[max] = temp;   
     }  
}
ArrayPrint(arr);
Collect(arr);
ArrayPrint(arr);