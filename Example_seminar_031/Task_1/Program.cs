Console.Write("Введите х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("Точка в начале координат");
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1-й четверти");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в 3-й четверти");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4-й четверти");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в 3-й четверти");
}