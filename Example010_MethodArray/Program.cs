int[] array = {1,5,19,4,3,6,1,19};

int n = array.Length;

int find = 19;

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}