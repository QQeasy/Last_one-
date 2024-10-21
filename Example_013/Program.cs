Console.Clear();
int pos = 2;
// a - позиция числа
void MaxDid(int a)
{
    int ramdomNum = new Random().Next(100, 1000);
    string num1 = Convert.ToString(ramdomNum/100);
    string num2 = Convert.ToString(ramdomNum%10);
    int num = Convert.ToInt32(num1 + num2);
Console.WriteLine(ramdomNum + " --> " + num);

}

MaxDid(pos);



