int pow(int n, int m)
{
    int res = n;
    for (int i = 1; i < m; i++)
    {
        res = res * n;
    }
    return res;
}

Console.Write("Введите число :");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени :");
int m = int.Parse(Console.ReadLine());
int res = pow(n, m);
Console.WriteLine($"Результат : {res}");


