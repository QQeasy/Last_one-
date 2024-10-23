Console.WriteLine("Введите координаты A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());


double range = Math.Sqrt((x2-x1)*(x2-x1) +(y2-y1)*(y2-y1));

Console.WriteLine(range);
