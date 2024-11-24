﻿
Console.Clear();

int[,] arrey1 = new int[new Random().Next(4, 10), new Random().Next(4, 10)];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine();

PrintArrey(NewArrey(arrey1));

int[,] NewArrey(int[,] arrey)

{
    int[,] newArrey = new int[arrey.GetLength(0), arrey.GetLength(1)];
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            newArrey[i, j] = arrey[i, j];
        }
    }
    
    for (int j = 0; j < arrey.GetLength(1); j++)
        {
            newArrey[arrey.GetLength(0)-1, j] = arrey[0, j];
            newArrey[0, j] = arrey[arrey.GetLength(0)-1, j];
        }
        
    
    return newArrey;
}


void PrintSimpleArrey(int[] newArrey1)
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