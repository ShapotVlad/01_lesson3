//ввод данных с консоли вывести на консоль


int size = 13;
int[] array = new int[size];
int i = 0;

while (i < size)
{
    Console.WriteLine("введите целое число массива:");

    string input = Console.ReadLine();
    array[i] = Convert.ToInt32(input);
    i++;
}

foreach (int e in array)
    {
        Console.Write($"{e}, ");
    }
