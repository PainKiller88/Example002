int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int []  array =  {4522,34,23,12,54,345,23,12,23};
//array[0] = 12;// как обратитс к массиву
//Console.WriteLine(array[0]);//так выводить значение массива на консоль

int result = Max (
    Max (array [0], array [1], array [2]),
    Max (array [3], array [4], array [5]),
    Max (array [6], array [7], array [8]));

    Console.WriteLine(result);

