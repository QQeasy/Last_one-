Console.Clear();
int[] arr = {1, 5, 6, 3, 2, 56, 7, 7, 85, 9, 12, 23};
void PrintArrey(int[] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(arrey[i]+ " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arrey)
{
    
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        int MinPos = i;
        for (int j = i + 1; j < arrey.Length; j++)
        {
            if (arrey[j] < arrey[MinPos]) MinPos = j;
        }
        int temporary = arrey[i];
        arrey[i] = arrey[MinPos];
        arrey[MinPos] = temporary;
    }
}

PrintArrey(arr);
int ReadNum(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void WriteCHET(int num)
{
    int i = 1;
    while (i < num + 1)
    {
        if (i%2==0)
        {
            Console.Write(i + " ");
        }
    i++;
    }
}
SelectionSort(arr);
PrintArrey(arr);