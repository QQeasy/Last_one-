/*Задача 62. Напишите программу, которая заполнит 
спирально массив 4 на 4.Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Console.Clear();

int[,] arrey1 = new int[4, 4];
arrey1[0, 0] = new Random().Next(9, 100);

FillRow(0, 0, 1, arrey1);
FillColumn(0, 3, 1, arrey1);

FillRow(3, 3, -1, arrey1);
FillColumn(3, 0, -1, arrey1);

FillRow(1, 0, 1, arrey1);
FillColumn(1, 2, 1, arrey1);

FillRow(2, 2, -1, arrey1);

PrintArrey(arrey1);




void FillRow(int сurI, int сurJ, int step, int[,] arrey1)
{
    for (int g = 0; g < arrey1.GetLength(1); g++)
    {
        for (int j = сurJ + step; arrey1[сurI, g] == 0; j += step)
    {
            arrey1[сurI, j] = arrey1[сurI, j - step] + 1;
    }
    }
}


void FillColumn(int сurI, int сurJ, int step, int[,] arrey1)
{
    for (int g = 0; g < arrey1.GetLength(0); g++)
    {
        for (int i = сurI + step; arrey1[g, сurJ] == 0; i += step)
        {
            arrey1[i, сurJ] = arrey1[i - step, сurJ] + 1;
        }
    }
}



int[,] FillSpiralArrey(int[,] arrey1)
{
    int imax = arrey1.GetLength(0);
    int jmax = arrey1.GetLength(1);
    int i1 = 0;
    int j1 = 0;
    for (int i = 0; i < arrey1.GetLength(0); i++)
    {
        for (int j = 0; j < arrey1.GetLength(1); j++)
        {
            if (i % 2 != 0)
            {
                i1 = i;
                j1 = j;
                FillRow(i1, j1, jmax, arrey1);
                jmax--;
            }
            else
            {
                FillColumn(i1, j1, jmax, arrey1);
                imax--;
            }
        }

    }
    return arrey1;
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
