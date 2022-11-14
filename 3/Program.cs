// Написать программу вычисления функции Аккермана

Console.Write("Введите значение m в функции Аккермана А(m,n): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n в функции Аккермана А(m,n): ");
int n= int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        n = n + 1;
        return n;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.WriteLine (Ackermann(m, n));