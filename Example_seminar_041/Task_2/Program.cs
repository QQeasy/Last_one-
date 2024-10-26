//Задача 26: Напишите программу, которая принимает на вход 
//число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Write($"Введите число, чтобы определить количество цифр в нём: ");
int i = ReadInt(); //ввод числа int'
int a1 = i;
int count = 0;
while (a1 != 0)
{
    a1/=10;
    count++;
}

Console.Write($"В числе {i} {count} цифр!");




int ReadInt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


