Console.Clear();

Console.Write($"Введите количество элементов Фибоначчи N: ");
int num1 = ReadNum();
Console.WriteLine("");

int[] arrey1 = new int[num1];

PrintArrey(arrey1);
Console.WriteLine(" ");
FillArrey(arrey1);
Console.Write($"Первые {num1} чисел(а) Фибоначчи: ");
Console.Write("( ");
PrintArrey(arrey1);
Console.WriteLine(")");


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
    arrey[0]= 0;
    arrey[1]= 1;
        for (int i = 0; i < arrey.Length-2; i++)
    {
        arrey[i+2] = arrey[i] + arrey[i+1];
    }
    return arrey;
}


//ввод чисел int
int ReadNum()
{
    int i = Convert.ToInt32(Console.ReadLine());
    return i;
}
