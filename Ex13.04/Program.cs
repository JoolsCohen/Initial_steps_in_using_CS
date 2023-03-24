// Написать программу вычисления факторил 3. Использовать рекурсию.

double Factorial(int n) // ! быстрорастущая функция, поэтому используем
{                       // тип данных double
   // 1! = 1
   // 0! = 1
   if (n ==1) return 1;
   else return n * Factorial(n-1);
}
    for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}