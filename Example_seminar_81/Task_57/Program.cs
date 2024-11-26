/*Задача 57: Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.*/
Console.Clear();

int[,] arrey1 = new int[new Random().Next(1, 5), new Random().Next(1, 5)];
FillArrey(arrey1);
PrintArrey(arrey1);
Console.WriteLine();
FreqDictionary(arrey1);


void FreqDictionary(int[,] arrey)

{
    int count = 0;
    for (int a = 0; a < 10; a++)
    {
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            for (int j = 0; j < arrey.GetLength(1); j++)
            {
                if (a == arrey[i, j])
                {
                    count++;
                }
            }

        }
        if (count > 0)
            {
                Console.WriteLine($"Число {a} в массиве встречается {count} раз!");
            }
            count = 0;
    }

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
            arrey[i, j] = new Random().Next(0, 10);
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