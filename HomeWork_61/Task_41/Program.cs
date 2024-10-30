Console.Clear();
string num1 = "";
int count = 0;
Console.WriteLine($"Вводите числа: ");
for (int i = 0; i < 999; i++)
{
    num1 = Console.ReadLine();
    if (num1 != "stop")
    {
        Convert.ToInt32(num1);
        count++;
    }
    else
    {
        break;
    }
}
Console.Write($"Из введенных чиcел - {count} положительных!");


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
