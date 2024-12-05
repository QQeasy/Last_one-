/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:*/
Console.Clear();




//test1
/*int[,] arrey1 = {   {10, 32, 42, 35, 36},
                    {21, 32, 54, 52, 65},
                    {17, 21, 49, 58, 10},
                    {17, 21, 49, 58, 10}    };

int[,] arrey2 = {   {12, 32, 25, 25},
                    {212, 54, 52, 52},
                    {17, 21, 58, 58},
                    {32, 45, 36, 36},
                    {21, 54, 52, 52}    };*/
//test2
/*int[,] arrey1 = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
int[,] arrey2 = new int[new Random().Next(2, 6), new Random().Next(2, 6)];*/
int[,] arrey1 = new int[new Random().Next(2, 4), new Random().Next(3, 5)];
int[,] arrey2 = new int[arrey1.GetLength(1), new Random().Next(1, 10)];


FillArrey(arrey1);
Console.WriteLine($"Матрица А имеет {arrey1.GetLength(0)} строк и {arrey1.GetLength(1)} столбцов: ");
Console.WriteLine();
PrintArrey(arrey1);
Console.WriteLine();
FillArrey(arrey2);
Console.WriteLine($"Матрица B имеет {arrey2.GetLength(0)} строк и {arrey2.GetLength(1)} столбцов: ");
Console.WriteLine();
PrintArrey(arrey2);
Console.WriteLine();
Console.WriteLine($"Результирующая матрица C = A x B имеет {arrey1.GetLength(0)} строк и {arrey2.GetLength(1)} столбцов: ");
Console.WriteLine();
MultiplyMatrix(arrey1, arrey2);


void MultiplyMatrix(int[,] arrey1, int[,] arrey2)
{
    int[,] arreyMultiply = new int[arrey1.GetLength(0), arrey2.GetLength(1)];
    int i1 = 0;
    int j1 = 0;
    int multiply = 0;
    if (arrey1.GetLength(1) == arrey2.GetLength(0))
    {
        for (int k = 0; k < arreyMultiply.GetLength(0); k++)
        {
            for (int l = 0; l < arreyMultiply.GetLength(1); l++)
            {
                for (int i = 0; i < arrey2.GetLength(0); i++)
                {
                    for (int j = 0; j < arrey1.GetLength(1); j++)
                    {
                        multiply += arrey1[k, j] * arrey2[j, l];
                    }
                    arreyMultiply[k, l] = multiply;
                    multiply = 0;
                }
            }
        }
    }

    else
    {
        Console.WriteLine($"Размерности матрицы А и матрицы B не подходят для перемножения!");
        Console.WriteLine($"В матрице А - {arrey1.GetLength(0)} столбцов, а в матрице B - {arrey2.GetLength(1)} строк.");
        Console.WriteLine($"Для умножения двух матриц необходимо, чтобы число столбцов первой матрицы равно числу строк второй.");
    }
    if (arreyMultiply[0, 0] != 0)
    {
        PrintArrey(arreyMultiply);
    }
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
