int m, n;
Console.Write("введите число m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число n: ");
n = Convert.ToInt32(Console.ReadLine());

void NumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine(sum); 
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}    

NumberSum(m, n, 0);