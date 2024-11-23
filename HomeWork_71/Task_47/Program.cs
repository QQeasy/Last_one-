
Console.Clear();

int a = ReadInt($"Введите количество строк массива: ");
int b = ReadInt($"Введите количество столбцов массива: ");

float[,] arrey1 = new float[a, b];
FillArrey(arrey1);
PrintArrey(arrey1);

float[,] FillArrey(float[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = (float)new Random().NextDouble() * 2;
        }
    }
    return arrey;
}
void PrintArrey(float[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
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