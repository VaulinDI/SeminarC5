long n = 6;
long m = 6;
long a = 4;

long x = (n + n % a) / a;
long y = (m + m % a) / a;

Console.WriteLine($"Количество плит для укладки площади: {x * y}");