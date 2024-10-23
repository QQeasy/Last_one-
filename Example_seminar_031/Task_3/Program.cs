Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
if (N<0)
{
    Console.WriteLine("число " + N + " - отрицательное");
}
for (int i = 1; i < N+1; i++)
{
    Console.WriteLine(i*i);
}