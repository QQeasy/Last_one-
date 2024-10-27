Console.Clear();

Console.Write($"Введите число элементов массива: ");
int num1 = ReadNum();
Console.WriteLine(" ");
int[] arrey1 = new int[num1];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine(" ");



int[] Arrey(int[] arrey)
{

    for (int i = 1; i < (arrey.Length+1)/2; i++)
    {
        if (arrey.Length%2 == 0)
        {
            int[] newArrey1 = new int[arrey.Length/2];
        }
        else
        {
            int[] newArrey1 = new int[arrey.Length/2+1];
        }
        newArrey1[i] = arrey[i]*arrey[(arrey.Length+1)-i];
    }
    return newArrey1;
}
PrintArrey(arrey1);




//поиск чисел на отрезке от А до Б в массиве arrey
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

//печать массива
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
