//ввод данных с консоли


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
