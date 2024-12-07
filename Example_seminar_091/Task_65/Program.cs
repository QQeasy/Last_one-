/*Задача 65: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.Clear();
int N = ReadInt("Задайте начальное число N: ");
int M = ReadInt("Задайте конечное число M: ");
Console.WriteLine(SequenceOFnum(N, M));



int SequenceOFnum(int a, int b)
{
    if (b == a)
        return a;
    if (a > b)
    {
        Console.Write(SequenceOFnum(a, b + 1) + ", ");
        return b;
    }
    else 
    {
        Console.Write(SequenceOFnum(a, b - 1) + ", ");
        return b;
    }
}



int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());

}