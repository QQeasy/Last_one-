Console.Clear();
/*Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.*/

int[,] numbers = new int[2, 5] {{1, 2, 3, 4, 65},
                                {3, 5, 6, 2, 5}};


Console.WriteLine(numbers.Rank);
Console.WriteLine(numbers.GetLength(0));
Console.WriteLine(numbers.GetLength(1));



int m = ReadInt($"Ведите число m - к-во строк массива: ");
int n = ReadInt($"Ведите число n - к-во столбцов массива: ");


//задание массива размерностью m×n
int[,] arreyZero = new int[m, n];

FillArrey(arreyZero);
PrintArrey(arreyZero);


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

//заполнение массива размерностью m×n
int[,] FillArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i,j] = new Random().Next(1,50);
        }
    }
    return arrey;
}

//введение числа
int ReadInt(string massege)
{
    Console.Write(massege);
return Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

}