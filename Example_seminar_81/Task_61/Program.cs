/*Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника*

***Треугольник Паскаля (арифметический треугольник) — бесконечная 
таблица биномиальных коэффициентов, имеющая треугольную форму. 
В этом треугольнике на вершине и по бокам стоят единицы. 
Каждое число равно сумме двух расположенных над ним чисел. 
Строки треугольника симметричны относительно вертикальной оси.*/

Console.Clear();


PrintArrey(PascalTr("Введите количество строк треугольника Паскаля: "));


int[,] PascalTr(string massage)
{
    Console.WriteLine(massage);
    int N1 = Convert.ToInt32(Console.ReadLine());
    //число элементов в строке:
    int N2 = 2 * N1 + 1;
    int[,] arrey = new int[N1, N2];
    arrey[0, N2 / 2] = 1;
    for (int i = 1; i < arrey.GetLength(0); i++)
    {
        for (int j = (N2 / 2) - i; j < arrey.GetLength(1)-1; j += 2)
        {
            arrey[i, j] = arrey[i - 1  , j-1 ] + arrey[i-1 , j+1 ];
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
            Console.Write($"{arrey[i, j]} ");
        }
        Console.WriteLine();
    }
}
