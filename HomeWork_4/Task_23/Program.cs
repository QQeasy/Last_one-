Console.Write("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

void sqrt(int N)
{
    for (int i = 1; i < N+1; i++)
    {
        Console.Write(i*i*i + " ");
    }
}
sqrt(n1);