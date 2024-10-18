Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.Write("Привет, "); Console.Write(username);
}
else
{
    Console.Write("Пока, "); Console.Write(username);
}