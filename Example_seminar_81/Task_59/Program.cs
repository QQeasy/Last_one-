/*Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.*/
Console.Clear();

int[,] arrey1 = new int[new Random().Next(4, 6), new Random().Next(4, 6)];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine();

SearchMinNUM(arrey1);
PrintSimpleArrey(SearchMinNUM(arrey1));
Console.WriteLine();
PrintArrey(DeleteMinNum(SearchMinNUM(arrey1), arrey1));

int[] SearchMinNUM(int[,] arrey)

{
    int minNum = 500;
    int mini = 500;
    int minj = 500;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (arrey[i, j] < minNum)
            {
                minNum = arrey[i, j];
                mini = i;
                minj = j;
            }
        }
    }
    int[] nums = { minNum, mini, minj };
    return nums;
}

int[,] DeleteMinNum(int[] arrey1, int[,] arrey2)
{
    int g = 0;
    int h = 0;
    int[,] newArrey = new int[arrey2.GetLength(0) - 1, arrey2.GetLength(1) - 1];
    for (int i = 0; i < arrey2.GetLength(0); i++)
    {
        if (i == arrey1[1])
            continue;
        for (int j = 0; j < arrey2.GetLength(1); j++)
        {
            if (j == arrey1[2])
                continue;
            newArrey[g, h] = arrey2[i, j];
            h++;
        }
        h = 0;
        g++;
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
