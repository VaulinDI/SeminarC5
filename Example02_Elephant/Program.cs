int x = 12;
int n = 0;
int y = x;
int maxstep = 5;
int z = x % maxstep;

void StepElephant()
{
if (x >= maxstep && x % maxstep == 0)
{
    n = x / maxstep;
}
else if (x < maxstep && x > 0)
{
    n = 1;
}
else if (x > maxstep && x % maxstep != 0)
{
    for (int i = maxstep; i > 0; i--)
    {    
        if (y > i)
        {
            y = x % i;
            x = x / i;
            z = x;
        }
        else if (y < i)
        {
            z = 0;
        }
        else if (y == i)
        {
            z = 1;
            y = 0;
        }
    n = n + z;
    } 
}
Console.WriteLine();
Console.WriteLine($"Минимальное количество шагов слоника: {n}");
}

StepElephant();