Console.Clear();
Console.Write($"Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 0;
int num2 = num1;

while (num2 != 0)
{
    num2 /= 2;
    count++;
    Console.WriteLine($"{num2}");
}


int num3 = num1;

Console.WriteLine($"{count} - число элементов массива.");
int[] newArrey = new int[count];
for (int i = 1; i < newArrey.Length+1; i++)
{

    newArrey[newArrey.Length - i] = num1%2;
    num1 /= 2;
}
Console.Write($"( ");
for (int i = 0; i < newArrey.Length; i++)
{
    Console.Write($"{newArrey[i]} ");
}
Console.Write($")");
Console.Write($" - десятичное представление числа {num3}");