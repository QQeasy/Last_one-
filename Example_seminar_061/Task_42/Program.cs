Console.Clear();
Console.Write($"Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 0;

FillArrey(num1);

void FillArrey(int num1)
{
    int n = num1;
    while (num1 != 0)
    {
    num1 /= 2;
    count++;
    Console.WriteLine($"{num1}");
    }

    Console.WriteLine($"{count} - число элементов массива.");

    int[] newArrey = new int[count];
    for (int i = 0; i < newArrey.Length; i++)
    {
        newArrey[i] = n %= 2;
        n /= 2;
    }

    for (int i = 0; i < newArrey.Length; i++)
    {
        Console.Write($"{newArrey[i]} ");

    }
}