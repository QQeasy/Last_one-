Console.Clear();
Console.Write($"Введите число: ");
int a1 = ReadInt();

int num1 = a1;
int count = 0;
while (num1 != 0)
{
    count += num1 % 10;
    num1 /= 10;
}

Console.WriteLine($"Сумма цифр в числе {a1} равняется {count} ");

//Методы 
//Считывает число
int ReadInt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}