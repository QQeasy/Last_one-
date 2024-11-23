
int m = ReadInt("Введите количество строк массива А: ");
int n = ReadInt("Введите количество столбцов массива А: ");

int[,] arreyA = new int[m,n];

FillArrey(arreyA);
PrintArrey(arreyA);
// заполнение массива

int[,] FillArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i,j] = i+j;            
        }
    }
    return arrey;
}

void PrintArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j <  arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i,j] + " ");
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