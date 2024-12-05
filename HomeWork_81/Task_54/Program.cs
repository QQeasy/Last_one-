/*Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.*/
Console.Clear();

int[,] arrey1 = new int[new Random().Next(4, 6), new Random().Next(4, 6)];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine();
ArrangeLineArrey(arrey1);
PrintArrey(ArrangeLineArrey(arrey1));

int[,] ArrangeLineArrey(int[,] arrey)
{
    int maxElem = -1000;
    for (int i = 0; i < arrey.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < arrey.GetLength(1) - 1; j++)
        {
            if (arrey[i, j] < arrey[i, j + 1])
            {
                maxElem = arrey[i, j + 1];
                arrey[i, j + 1] = arrey[i, j];
                arrey[i, j] = maxElem;
            }
        }
        maxElem = -1000;
    }
    return arrey;
}



void Print2DArrey(int[] newArrey1)
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
            arrey[i, j] = new Random().Next(9, 50);
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
