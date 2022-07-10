int Max(int Arg1, int Arg2, int Arg3)
{
    int resault = Arg1;

    if (Arg2 > resault) resault = Arg2;
    if (Arg3 > resault) resault = Arg3;

    return resault;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);