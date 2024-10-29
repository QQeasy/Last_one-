Console.Clear();
Console.WriteLine($"Введите два числа:");




TrGipotenuza(Read2Num());



void TrGipotenuza(int[] arrey)
{   
    if (arrey.Length > 3)
    {
    Console.WriteLine($"Вы ввели слишком много чисел! У треугольника три стороны!");
    }
    if (arrey[0] < arrey[1] + arrey[2] && 
        arrey[1] < arrey[2] + arrey[0] && 
        arrey[2] < arrey[0] + arrey[1])
    {
        Console.WriteLine($"Tреугольник c такими сторонами существует!");
    }
    else
    {
        Console.WriteLine($"Треугольника с такими сторонами быть не может!");
    }
}
    



int[] Read2Num()
{
    int[] storoni = new int[3];
    for (int i = 0; i < storoni.Length; i++)
    {
        storoni[i] = Convert.ToInt32(Console.ReadLine());
    }
    return storoni;
}

void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");

    }
}