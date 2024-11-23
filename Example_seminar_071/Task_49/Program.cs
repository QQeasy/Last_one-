
/*Задача 49: Задайте двумерный массив. Найдите элементы, у 
которых оба индекса нечётные, и замените эти элементы на 
их квадраты.*/


int m = ReadInt("Введите количество строк массива А: ");
int n = ReadInt("Введите количество столбцов массива А: ");

int[,] arreyA = new int[m, n];

FillArrey(arreyA);
PrintArrey(arreyA);
Console.WriteLine();
// заполнение массива
NewArrey(arreyA);
PrintArrey(arreyA);

int[,] FillArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(2, 10);
        }
    }
    return arrey;
}

int[,] NewArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if ((i % 2 == 1) && (j % 2 == 1))
            {
                arrey[i, j] = arrey[i, j] * arrey[i, j];
            }
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
//введение числа
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}