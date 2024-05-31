//вычислить  значение формолы  (a*b)/(c+d)
//решение оформить в виде функции


double CalculFormula(int a, int b, int c, int d) //создали локальную возвратную функцию
{
    double num1 = a * b;                         // тело функции, что она делает 
    int num2 = c + d;
    double result = num1 / num2;
    return result;                              // возвращаем результат   функции для дальнейшего пользования
}

double result = CalculFormula(45, 78, 45, 25);  //вызовваем локальную функцию и вводим параметры
Console.WriteLine(result);                     // вывод результата 
