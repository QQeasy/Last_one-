Console.Clear();

Console.Write($"Введите к-во элементов массива А: ");
int num1 = ReadNum();
Console.WriteLine("");

int[] arrey1 = new int[num1];

PrintArrey(arrey1);
Console.WriteLine(" ");
FillArrey(arrey1);
Console.Write($"Введенный массив А: ");
Console.Write("( ");
PrintArrey(arrey1);
Console.WriteLine(")");
Console.Write($"Новый массив B: ");
Console.Write("( ");
int[] newArrey = newArrey1(arrey1);
PrintArrey(newArrey);
Console.WriteLine(")");


int[] newArrey1(int[] arrey)
{
    int[] newArrey = new int[arrey.Length];
    for (int i = 0; i < arrey.Length; i++)
    {
        newArrey[i] = arrey[i];
    }
    return newArrey;
}

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
        arrey[i] = new Random().Next(1, 29);
    }
    return arrey;
}


//ввод чисел int
int ReadNum()
{
    int i = Convert.ToInt32(Console.ReadLine());
    return i;
}
