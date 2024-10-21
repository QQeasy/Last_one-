Console.Clear();


int RandomInt(string massage)
{
    int i = 0;
    int num = Convert.ToInt32(Console.ReadLine());
    int [] arrey = new int[num];
    while ( i < num)
    {
        arrey[i] = new Random().Next(1, 1000);
        i++;
    }
    return arrey[1];
    massage = Console.Write("Введите к-во цифр для сравнения");
}

RandomInt();
