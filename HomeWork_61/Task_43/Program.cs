Console.Clear();

Console.WriteLine($"Вводите значения k1, b1: ");
int k1 = ReadNum();
int b1 = ReadNum();
Console.WriteLine($"Вводите значения k2, b2: ");
int k2 = ReadNum();
int b2 = ReadNum();

Console.Write($"Для того, чтобы найти точку пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2} введите 'YES': ");
string result = Console.ReadLine();
float x = 0;
float y = 0;
if (result == "YES")
{
    x = ((b2 - b1) / (k1 - k2));
    y = x*k1 + b1;
    Console.Write($"Точка пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2} - ({x}:{y}):");
}


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
