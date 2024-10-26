Console.Clear();
Console.Write("Введите число - палиндром: ");
int a1 = Convert.ToInt32(Console.ReadLine());
int count = 0;
int n1 = a1;

while (n1 != 0)
{
    n1/=10;
    count++;
}
n1 = a1;
int a2 = a1;
int b2 = a1;
int summ = 0;

for (int i = 1; i < count/2 + 1; i++)
{
    a2 %= 10;
    
    for (int j = 0; j < count-i; j++)
    {
        b2 /= 10;
    }
    b2 %= 10;

    //проверку сделать
    if (a2 == b2)
    {
        summ ++;
    }

    Console.WriteLine(i + " " + a2 + " " + b2 + " " + count + " " + summ);  
    n1 /=10;
    a2 = n1;
    b2 = a1;
}

if (summ == count/2)
{
    Console.WriteLine("Число " + a1 + " является палиндромом!");
}
else
{
    Console.WriteLine("Число " + a1 + " не является палиндромом!");
}