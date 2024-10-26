//Задача 24: Напишите программу, которая принимает на 
//вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Clear();
Console.Write($"Введите число А: ");
int a1 = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i < a1+1; i++)
{
    sum += i;
}

Console.WriteLine($"{sum} - сумма числе от 1 до {a1}");

