
Console.Clear();


int[,] arrey1 = new int[new Random().Next(4, 6), new Random().Next(4, 8)];
FillArrey(arrey1);
PrintArrey(arrey1);

int a = ReadInt($"Введите номер строки элемента массива, который необходимо отобразить: ");
int b = ReadInt($"Введите номер столбца элемента массива, который необходимо отобразить: ");

if (a > arrey1.GetLength(0) || b > arrey1.GetLength(1))
{   
    Console.WriteLine($"Элемента массива с позицией ({a},{b}) не существует!");
}
else
{
    Console.WriteLine($"{arrey1[a, b]} - искомый элемент массива!");
}

int[,] FillArrey(int[,] arrey)
{
    for (int i = 1; i < arrey.GetLength(0); i++)
    {
        for (int j = 1; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(1,30);
        }
    }
    return arrey;
}
void PrintArrey(int[,] arrey)
{
    for (int i = 1; i < arrey.GetLength(0); i++)
    {
        for (int j = 1; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());

}