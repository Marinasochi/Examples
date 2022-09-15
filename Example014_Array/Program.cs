void FillArray(int[] collection) // Генерирует массив случайных чисел длиной length
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
    collection[index] = new Random().Next(1,10);
    Console.WriteLine($"{index+1} элемент массива: {collection[index]}");
    index++;
    }
}

void PrintArray(int[] col) //Выводит на экран элементы массива
{
    int count = col.Length;
    int posicion = 0;
    while(posicion<count)
    {
        Console.WriteLine(col[posicion]);
        posicion++;
    }
}

int Indexof(int[] collect, int find) //Ищет индекс элемента с конкретным значением
{
    int lengthindex = collect.Length;
    int place =0;
    int result = -1;
    while(place<lengthindex)
    {
        if (collect[place] == find)
        {
        result = place;
        }
        place++;
    }
    if (result < 0) Console.WriteLine("Такой элемент не найден");
    return result;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Искомый элемент имеет индекс: {Indexof(array, 1)}");

