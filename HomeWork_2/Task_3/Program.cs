Console.Clear();

Console.WriteLine("Введите к-во цифр для сравнения");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int max1 = -11;
while (i < num)
{
    Console.WriteLine("Введите " + (i + 1) + " цифру:");
    int a1 = Convert.ToInt32(Console.ReadLine());
    if (a1 > max1)
    {
        max1 = a1;
    }
    i++;
}
Console.WriteLine("Максимальная введенная цифра - " + max1);


