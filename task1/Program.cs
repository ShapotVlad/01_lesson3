//вычислить  значение формолы  (a*b)/(c+d)
//решение оформить в виде формулы


double CalculFormula(int a, int b, int c, int d)
{
    double num1 = a * b;
    int num2 = c + d;
    double result = num1 / num2;
    return result;
}

double result = CalculFormula(5, 78, 45, 25);
Console.WriteLine(result);
