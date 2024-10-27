Console.Clear();

Console.Write($"Введите число элементов массива: ");
int n = ReadNum();
Console.WriteLine(" ");
int[] arrey1 = new int[n];

PrintArrey(arrey1);
FillArrey(arrey1);
PrintArrey(arrey1);
SumElemArrey(arrey1);
PrintArrey(arrey1);
int[] SumElemArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] *= -1;
    }
    return arrey;
}

void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

//заполнение массива случайными числами
int[] FillArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(-9, 9);
    }
    return arrey;
}


//ввод чисел int
int ReadNum()
{
    int i = Convert.ToInt32(Console.ReadLine());
    return i;
}
