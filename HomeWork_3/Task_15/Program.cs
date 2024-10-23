Console.WriteLine("Введите номер дня недели:");
int WeekDay = Convert.ToInt32(Console.ReadLine());
if (WeekDay > 5 && WeekDay <= 7)
{
    Console.WriteLine(WeekDay + "-й день недели - это выходной!");
}
else
{
    Console.WriteLine(WeekDay + "-й день недели - это будний день!");
}