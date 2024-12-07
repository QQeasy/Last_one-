/*Задача 67: Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
Console.Clear();
int N = ReadInt("Введите число для подсчета суммы цифр в нём: ");
int summ = 0;
Console.WriteLine(SummNumm(N));



int SummNumm(int a)
{
    if (a == 0)
    {
        return summ;
    }
    else
    {
        summ += a % 10;
        a = SummNumm(a / 10);
        return a;
    }
}



int ReadInt(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());

}