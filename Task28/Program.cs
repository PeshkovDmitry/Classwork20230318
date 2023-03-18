int Factorial(int n) {
    int f = 1;
    for (int i = 1; i <= n; i++)
        f *= i;
    return f; 
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(n));
