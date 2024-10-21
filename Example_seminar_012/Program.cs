Console.Clear();
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());

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



