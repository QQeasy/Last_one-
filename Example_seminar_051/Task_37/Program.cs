Console.Clear();

Console.Write($"Введите число элементов массива: ");
int num1 = ReadNum();
Console.WriteLine(" ");
int[] arrey1 = new int[num1];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine(" ");

//создаёт новый массив на основе введённого 
//посредством суммирования первого и последнего элемента, второго и предпоследнего
int[] NewArreySumm(int[] arrey)
{
    int num1 = 0;
    int num2 = 0;
    if (arrey.Length % 2 == 0)
    {
        num1 = arrey.Length / 2;
    }
    else
    {
        num2 = arrey.Length / 2 + 1;
    }
    int num3 = num1 + num2;
    int[] arrey2 = new int[num3];
    if (num3 % 2 == 0)
    {
        for (int i = 0; i < num3; i++)
        {
        arrey2[i] = arrey[i] + arrey[arrey.Length - i - 1]; 
        }
    }
    else
    {
        for (int i = 0; i < num3; i++)
        {
        arrey2[i] = arrey[i] + arrey[arrey.Length - i - 1]; 
        }
        arrey2[num3-1] = arrey[arrey.Length-num3];
    }

    return arrey2;


}

PrintArrey(NewArreySumm(arrey1));



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
