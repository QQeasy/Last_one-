Console.Clear();

int num = ReadNum("Введите число");
if (num%2==0)
{
    Console.WriteLine("Число " + num + " является четным!");
}
else
{
    Console.WriteLine("Число " + num + " является нечетным!");
}

// ввод числа int
int ReadNum(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

