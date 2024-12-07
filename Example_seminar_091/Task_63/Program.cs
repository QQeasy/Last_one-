/*Задача 63: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/
Console.Clear();
int n = ReadInt("Задайте число: ");
Console.WriteLine(SequenceOFnum(n));



int SequenceOFnum(int a)
{
    if (a == 1)
        return 1;

    else
    {
        Console.Write(SequenceOFnum(a - 1) + ", ");
    }
    return a;
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());

}