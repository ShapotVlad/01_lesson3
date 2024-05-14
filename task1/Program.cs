//вычислить  значение формолы  (a*b)/(c+d)
//решение оформить в виде функции


double CalculFormula(int a, int b, int c, int d) //создали функцию
{
    double num1 = a * b;                         // тело функции, что она делает 
    int num2 = c + d;
    double result = num1 / num2;
    return result;                              // возврат  функции
}

double result = CalculFormula(45, 78, 45, 25);  //вызов функции
Console.WriteLine(result);                     // вывод результата 
