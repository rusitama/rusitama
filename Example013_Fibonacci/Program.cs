
// f(1) = 1
// f(2) = 2
// f(n) = f(n - 1) + f(n - 2)

int Fibonnaci(int n){
    if (n == 1 || n == 2) return n;
    else return Fibonnaci(n - 1) + Fibonnaci(n - 2);
}

for (int i = 1; i < 50; i++) 
{
    Console.WriteLine($"f({i}) = {Fibonnaci(i)}");
}