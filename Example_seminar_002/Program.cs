Console.Clear();
Console.WriteLine("Введите номер дня недели:");
string week = Console.ReadLine();
int num = Convert.ToInt32(week);
if (num == 1)
{
    Console.WriteLine(num + "-й день недели - это понедельник!");
}
if (num == 2)
{
    Console.WriteLine(num + "-й день недели - это вторник!");
}
if (num == 3)
{
    Console.WriteLine(num + "-й день недели - это среда!");
}
if (num == 4)
{
    Console.WriteLine(num + "-й день недели - это четверг!");
}
if (num == 5)
{
    Console.WriteLine(num + "-й день недели - это пятница!");
}
if (num == 6)
{
    Console.WriteLine(num + "-й день недели - это суббота!");
}
if (num == 7)
{
    Console.WriteLine(num + "-й день недели - это воскресенье!");
}
if (num > 7)
{ 
    Console.WriteLine(num + " - вы ввели неверное число, оно не соответсвтует диапазону (1:7)");
}
