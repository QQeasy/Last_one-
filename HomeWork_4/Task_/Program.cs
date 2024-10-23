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
int a2 = 0;
int b2 = a1;

n1 = a1;

Console.WriteLine(count + " " + n1);
for (int i = 0; i < count; i++)
{   
    a2 = a1%10;
    a1 /= 10;
    for (int j = count-1; j > i; j--)
    {
        b2 = b2/10;
        int n23 = b2%10;
        Console.WriteLine(i + " " + a2 + " " + n23);
    }
    if (a2 == n23)
    {
        continue;
    }
    else
    b2 = n1;
}


