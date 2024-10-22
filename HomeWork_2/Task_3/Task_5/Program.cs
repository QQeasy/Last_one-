Console.Clear();
int ReadNum(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void WriteCHET(int num)
{
    int i = 1;
    while (i < num + 1)
    {
        if (i%2==0)
        {
            Console.Write(i + " ");
        }
    i++;
    }
}
int num1 = ReadNum("Введите количество чисел N:");
WriteCHET(num1);