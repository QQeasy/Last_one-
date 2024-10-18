
Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
int numA = Convert.ToInt32(num1);
Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
int numB = Convert.ToInt32(num2);
  
if (numA*numA == numB)
{
    Console.WriteLine("Число " + numB + " является квадратом числа " + numA);
}
else
{
    Console.WriteLine("Число " + numB + " не является квадратом числа " + numA);
}
   