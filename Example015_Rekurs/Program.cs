// Рекурсия для факториала
int Factorial (int n)
{
    if (n == 1) 
        return 1;
    else 
        return n * Factorial(n-1);
}

Console.WriteLine(Factorial(5));


// Последовательность Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci (int num)
{
    if (num == 1 || num == 2 ) return 1;
    else 
    return Fibonacci (num-1) + Fibonacci (num - 2);
}

for (int i = 1; i<10; i++)
{
    Console.WriteLine (Fibonacci (i));
}

