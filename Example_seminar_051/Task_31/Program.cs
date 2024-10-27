Console.Clear();
Console.Write($"Введите число элементов массива: ");
int a1 = ReadInt();

int[] arrey1 = new int[a1];
Console.WriteLine(" ");
PrintArrey(arrey1);
FillArrey(arrey1);
Console.WriteLine(" ");
PrintArrey(arrey1);
Console.WriteLine(" ");
int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arrey1.Length; i++)
{

    if (arrey1[i] < 0)
    {
        sumNeg += arrey1[i];
    }
    else
    {
        sumPos += arrey1[i];
    }
}
Console.WriteLine($"Сумма положительных элементов массива равна {sumPos};");
Console.WriteLine(" ");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNeg}.");
Console.WriteLine(" ");
//Методы 
//Считывает число
int ReadInt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

//1 заполняет
int[] FillArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(-9, 9);
    }
    return arrey;

}
//выводит массив
int[] PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine(" ");
    return arrey;
    
}