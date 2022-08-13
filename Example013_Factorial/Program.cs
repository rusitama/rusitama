double Factor(int n)
{
    // 1! = 1;
    // 0! = 1;
    if (n == 1) return n;
    else return n * Factor(n - 1);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i}! = {Factor(i)}");
}