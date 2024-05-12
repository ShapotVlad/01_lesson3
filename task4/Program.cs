//заполнение массива случайными числами от  1 до 9 включительно
// вывод на консоль их

Random rnd = new Random();

int size = 940;
int[] array = new int[size];

int i = 0;
while (i < size)
{
    array[i] = rnd.Next(1, 95);
    i++;
}

i = 0;
while (i < size)
{
    Console.Write($"{array[i]} ");
    i++;
  }