Console.Clear();
Console.Write($"Введите число элементов массива: ");
int a1 = ReadInt();

int[] arrey1 = new int[a1];

PrintArrey(arrey1);
FillArrey(arrey1);
PrintArrey(arrey1);


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
        arrey[i] = new Random().Next(0, 10);
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
