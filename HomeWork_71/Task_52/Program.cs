
Console.Clear();

int[,] arrey1 = new int[new Random().Next(4, 10), new Random().Next(4, 10)];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine();

PrintSimpleArrey(FindAverJJJ(arrey1));



float[] FindAverJJJ(int[,] arrey)

{
    float[] newArrey = new float[arrey.GetLength(0)];
    float summJ = 0;

    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            summJ += arrey[i, j];
            newArrey[j] = summJ/arrey.GetLength(0);
        }
        
        summJ = 0;
    }
    return newArrey;
}


void PrintSimpleArrey(float[] newArrey1)
{
    for (int i = 0; i < newArrey1.Length; i++)
    {
        Console.Write($"{newArrey1[i]} ");
    }

}

int[,] FillArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(1, 30);
        }
    }
    return arrey;
}
void PrintArrey(int[,] arrey)
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