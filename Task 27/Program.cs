
int digitsum(int num)
{
    int n = Math.Abs(num);
    int sum = 0;
    while (n > 0)
    {
        int digit = n%10;
        sum = sum + digit;
        n = n/10;
    }
    return sum;
}

Console.WriteLine("Введите число :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна {digitsum(n)}");

