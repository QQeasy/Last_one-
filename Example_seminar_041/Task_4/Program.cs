Console.Clear();
Console.Write($"Введите количество элементов массива: ");


int num1 = ReadInt();

int[] numbers = new int[8];

FillArrey(numbers);

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