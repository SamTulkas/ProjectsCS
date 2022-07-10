int Max(int Arg1, int Arg2, int Arg3)
{
    int resault = Arg1;

    if (Arg2 > resault) resault = Arg2;
    if (Arg3 > resault) resault = Arg3;

    return resault;
}

int[] array = { 11, 211, 31 ,41 ,15 ,61 ,17 ,18 ,19};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
