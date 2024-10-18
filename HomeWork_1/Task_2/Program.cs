//программа выводит максимум из количества введенных чисел
Console.WriteLine("Введите количество сравниваемых чисел:");
int summ = Convert.ToInt32(Console.ReadLine());
int max = -1*10^55;
int i = 1;
while (i < summ+1)
{
    Console.WriteLine("Введите " + i + " число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 > max)
    {
        max = num1;
    }
    i ++;
}
Console.WriteLine("Максимальное введенное число - " + max);