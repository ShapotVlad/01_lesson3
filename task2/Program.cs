﻿//вывод на экран квадратов чисел от 0 до N.

void PrintSqure(int n) //создаем безвозратную локальную функции для вывода
{
    int i = 1;   //задаем цельную переменную начала цикла
    while (i <= n) // задаем цикл "пока"
    {
        Console.Write($"{i * i} ");//возводим переменную в квадрат и выводим на консоль 
        i++;                       // увеличиваем на 1 переменную
    }
}


PrintSqure(22);//вызываем локальную функцию и вводим значение параметра n
