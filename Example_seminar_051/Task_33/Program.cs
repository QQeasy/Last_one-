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
Console.Write($"Введите число, которое хотите найти в массиве: ");
int num2 = ReadNum();
Console.WriteLine(" ");

FindNum2(arrey1, num2);




void FindNum2(int[] arrey, int num)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] == num)
        {
            Console.Write($"Число {num} в массиве ");
            PrintArrey(arrey);
            Console.WriteLine($" ЕСТЬ!");
            Console.WriteLine($"Оно находится на {i} позиции!");
            count++;
        }
    }
    if (count == 0)
    {
        Console.Write($"Числа {num} в массиве ");
        PrintArrey(arrey);
        Console.Write($"НЕТ!");
    }
    
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
