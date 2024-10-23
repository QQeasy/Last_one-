Console.Clear();

int num1 = new Random().Next(1020,2222233);
int n1 = num1;
int nomer = Convert.ToInt32(Console.ReadLine());

//вычисляет степень для 10
int Pow(int b)
{
    int a = 10;
    while (b > 1)
    {
        a = a * 10;
        b = b - 1;
    }
    return a;
}

int a = Pow(nomer);


while (n1 > a)
{
    n1 = n1 / 10;
}
int cifra = n1%10;
if (num1<a/10)
{
    Console.WriteLine("В веденном числе " + num1 + " нет цифры под номером " + nomer);
}
else
{
    Console.WriteLine(nomer + "-я цифра числа " + num1 + " - это " + cifra);
}

