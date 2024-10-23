Console.Clear();
int ReadInt(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void secondNum(int num)
{
    int secondNum = num%100/10;
    Console.WriteLine(secondNum + " - вторая цифра числа " + num);
}
secondNum(ReadInt("Введите число:"));