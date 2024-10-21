
Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 113;
int a2 = 3;
int a3 = 1;

Console.WriteLine(Max(a1, a2, a3));
