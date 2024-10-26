//Задача 28: Напишите программу, которая принимает на вход 
//число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.Write($"Введите число чисел N: ");
int a = ReadInt();
int mult = 1;
for (int i = 1; i < a+1; i++)
{
    mult *= i;
}
Console.WriteLine($"Произведение чисел от 1 до {a} = {mult}");





int ReadInt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}