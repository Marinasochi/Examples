int[] array = {78,12,6,12,0,56,47,12,12};
int n = array.Length;
int index=0;
int find = 12;
while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
