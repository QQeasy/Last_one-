Console.Clear();
int Num1 = ReadInt("Введите первое число: ");
int Num2 = ReadInt("Введите второе число: ");

void sqrt2(int a, int b)
{
   
    if (a*a == b || b*b == a)
    {
       Console.WriteLine("ДА"); 
    }
    else
    {
       Console.WriteLine("НЕТ");
    }
}

sqrt2(Num1, Num2);

int ReadInt(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
}


