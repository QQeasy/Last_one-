/*Задача 60. ...Сформируйте трёхмерный массив из случайных 
неповторяющихся двузначных чисел. Напишите программу, которая 
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/
Console.Clear();

int[,,] arrey1 = new int[new Random().Next(2, 5), new Random().Next(2, 5), new Random().Next(2, 5)];

Fill3DArrey(arrey1);

Console.WriteLine($"В заданном массиве {arrey1.Length} элементов: ");
Console.WriteLine();
Print3DArrey(arrey1);

void Print3DArrey(int[,,] arrey1)
{
    for (int k = 0; k < arrey1.GetLength(2); k++)
    {
        for (int i = 0; i < arrey1.GetLength(0); i++)
        {
            for (int j = 0; j < arrey1.GetLength(1); j++)
            {
                Console.Write($"{arrey1[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        if (k != arrey1.GetLength(2) - 1)
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}



int[,,] Fill3DArrey(int[,,] arrey)
{
    for (int k = 0; k < arrey.GetLength(2); k++)
    {
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            for (int j = 0; j < arrey.GetLength(1); j++)
            {
                arrey1[i, j, k] = new Random().Next(9, 100);
            }
        }
    }
    return arrey;
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());

}
