Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
Console.WriteLine("Максимальное введенное число - " + max);