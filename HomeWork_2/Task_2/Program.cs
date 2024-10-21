Console.Clear();
int Num1 = ReadInt("Введите первое число: ");
int Num2 = ReadInt("Введите второе число: ");

void sqrt2(int a, int b)
{
   
    if (a > b)
    {
       Console.WriteLine(a + " - большее число");
       Console.WriteLine(b + " - меньшее число"); 
    }
    else
    {
       Console.WriteLine(b + " - большее число");
       Console.WriteLine(a + " - меньшее число"); 
    }
}

sqrt2(Num1, Num2);

int ReadInt(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
}


