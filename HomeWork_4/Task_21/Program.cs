Console.Clear();
Console.WriteLine("Введите координаты точки А");
Console.Write("Координата x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("Координата x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int count = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1);
double summ = Math.Sqrt(count);
Console.WriteLine(summ);