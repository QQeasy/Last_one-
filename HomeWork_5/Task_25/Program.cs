Console.Clear();
Console.Write($"Введите число, которое хотите возвести в степень: ");
int a1 = ReadInt();
Console.Write($"Введите, в какую степень возвести число {a1}: ");
int a2 = ReadInt();

int powA1 = 1;

for (int i = 0; i < a2; i++)
{
    powA1 *= a1;
}
Console.Write($"Число {a1} в степени {a2} ровняется {powA1}");

//Методы 
//Считывает число
int ReadInt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

//1 заполняет и выводит массив
int[] FillArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(0, 2);
        Console.Write($"{arrey[i]} ");
    }
    return arrey;

}