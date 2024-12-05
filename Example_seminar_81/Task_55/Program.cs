/*Доп. задача 55**: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение 
для пользователя. Решить НЕ используя второй массив*/

Console.Clear();

int[,] arrey1 = new int[5, new Random().Next(5, 7)];
FillArrey(arrey1);
Console.WriteLine($"Исходный массив: ");
Console.WriteLine();
PrintArrey(arrey1);
Console.WriteLine();

if (arrey1.GetLength(0) == arrey1.GetLength(1))
{
    Console.WriteLine($"Изменённый массив: ");
    Console.WriteLine();
    PrintArrey(NewArrey(arrey1));
}
else
    {
        Console.WriteLine($"Невозможно заменить строки на столбцы в приведенном массиве.");
        Console.WriteLine($"Необходимо, чтобы количество строк массива ровнялось его количеству столбцов:");
        Console.WriteLine($"исходный массив имеет {arrey1.GetLength(1)} строк и {arrey1.GetLength(0)} столбцов");
    }
int[,] NewArrey(int[,] arrey)

{
int elem = 0;
for (int i = 0; i < arrey.GetLength(1); i++)
{
    for (int j = 0; j != i; j++)
    {
        elem = arrey[j, i];
        arrey[j, i] = arrey[i, j];
        arrey[i, j] = elem;

    }
}
return arrey;
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
            arrey[i, j] = new Random().Next(1, 10);
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