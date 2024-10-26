Console.Clear();
Console.Write($"Введите число для возведения в степень: ");
int a1 = ReadInt();
Console.Write($"Введите степень, в которую возвести число {a1}: ");
int a2 = ReadInt();
int powA1 = a1;

for (int i = 1; i < a2; i++)
{
    powA1 = powA1 * powA1;
}

Console.WriteLine($"Число {a1} в степени {a2} равняется {powA1} ");

//Методы 
//Считывает число
int ReadInt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}