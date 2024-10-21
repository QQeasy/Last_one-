Console.Clear();


void FillArrey(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < length)
    {
        collection[i] = new Random().Next(20, 150);
        i++;
    }
        
}

void PrintArrey(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(col[pos] + " ");
        pos++;
    }

}

int IndexOF(int[] collection, int find)
{
    int i = 0;
    int pos = -1;
    while (i < pos)
    {
        if (collection[i]==find)
        {
            pos = i;
        }
        i++;
    }
    return pos;
}

int [] arrey = new int[10];


FillArrey (arrey);
PrintArrey(arrey);
int pos = IndexOF(arrey, 4);
Console.WriteLine(pos);

