Console.Clear();

Console.Write($"Введите число элементов массива: ");
int num1 = ReadNum();
Console.WriteLine(" ");

int[] arrey1 = new int[num1];

PrintArrey(arrey1);
Console.WriteLine(" ");
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine(" ");
Console.Write($"Введите отрезок чисел, котрые необходимо найти в массиве: ");
int numA = ReadNum();
int numB = ReadNum();
Console.WriteLine(" ");

FindSumNum(arrey1, numA, numB);




void FindSumNum(int[] arrey, int A, int B)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] >= A && arrey[i] <= B)
        {
            count++;
        }
    }
    Console.WriteLine($"В массиве:");
    PrintArrey(arrey);
    Console.WriteLine(" ");
    Console.Write($"находится {count} чисел(числа) от {A} до {B}");
}

void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
    }

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
