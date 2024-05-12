// обнулить четные  значения массива



void ZeroEvenElements(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            numbers[i] = 0;
        }
    }
}

void PrintArray(int[] numbers)
{
    foreach (int e in numbers)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 9, 8, 12, 5, 13, 4, 7 };
ZeroEvenElements(array);
PrintArray(array);
