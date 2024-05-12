//вывод на экран квадратов чисел от 0 до N.

void PrintSqure(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}


PrintSqure(22);
