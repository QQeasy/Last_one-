/*Задача 69: Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.Clear();
int num = ReadInt("Введите число для возведения в степень: ");
int m = ReadInt("Введите степень");
int multiply = num;
Console.WriteLine(MultiplyNumA(num, m));



int MultiplyNumA(int a, int b)
{
    if (b == 1)
        return multiply;
    else
    {
        multiply *= MultiplyNumA(a, b - 1);
        return multiply;
    }
}



int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());

}