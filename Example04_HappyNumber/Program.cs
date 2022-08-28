long num = 107407450;
Console.WriteLine(num);
long x = 0;
int count = 0;

for (long i = 1; i < num; i = i * 10)
{
    x = num / i % 10;
    if (x == 4 || x == 7)
    {
        count++;
    }
}

if (count == 4 || count == 7)
{
    Console.WriteLine("Число является почти счастливым");
}
else
{
    Console.WriteLine("Число НЕ является почти счастливым");
}