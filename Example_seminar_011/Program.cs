Console.Clear();
int min = 10;
int max = 99; 

void MaxDid(int a, int b)
{
    int ramdomNum = new Random().Next(a, b+1);
    a = ramdomNum/10;
    b = ramdomNum%10;
    int max = 0;
    if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine(ramdomNum + " -> " + max);
}
MaxDid(min,max);


