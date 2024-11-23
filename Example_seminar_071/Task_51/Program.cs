/*Задайте двумерный массив. Найдите сумму элементов, находящихся 
на главной диагонали (с индексами (0,0); (1;1) и т.д.*/
Console.Clear();

int a = ReadInt($"Введите количество строк массива: ");
int b = ReadInt($"Введите количество столбцов массива: ");

int[,] arrey1 = new int[a, b];
FillArrey(arrey1);
PrintArrey(arrey1);
int sum = SeekSumm(arrey1);
Console.WriteLine($"Сумма элементов главной диаганали сгенерированного массива - {sum}!");


int SeekSumm(int[,] arrey)
{
    int count = 0;
        for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (i == j)
            {
                count += arrey[i,j];
                break;
            }
        }

    }
    return count;
}










int[,] FillArrey(int[,] arrey)
{
        for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(1,50);
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