int k = 3;
int n = 17;
int w = 4;
int sumprice = 0;

for (int i = 1; i <= w; i++)
{
    sumprice = sumprice + k * i;
}
Console.WriteLine($"Общая стоимость бананов: {sumprice} долларов");
Console.WriteLine($"Солдату придется одолжить: {sumprice - n} долларов");