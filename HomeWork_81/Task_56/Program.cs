/*Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов*/
Console.Clear();

int[,] arrey1 = new int[new Random().Next(4, 6), new Random().Next(4, 6)];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine();
SearchMinRowSummElements(arrey1);


void SearchMinRowSummElements(int[,] arrey)
{
    int minI = 0;
    int count1 = 0;
    int count2 = 10000; // cчетчик для 
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            count1 += arrey[i, j];
        }
        if (count1 < count2)
        {
            count2 = count1;
            minI = i+1;
        }
        count1 = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {minI} (сумма = {count2})");
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
