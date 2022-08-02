Console.Write("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int ak(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return ak(m - 1, 1);
    else if (m > 0 && n > 0)
        return ak(m - 1, ak(m, n - 1));
return ak(m, n);
}
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {ak(m, n)}");
