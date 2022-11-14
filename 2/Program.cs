// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите целое число ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число ");
int N = Convert.ToInt32(Console.ReadLine());

int SummNumbers(int M, int N)
{

    if (M == N) return M;

    else if (M < N) return N + SummNumbers(M, N - 1);
    else return N + SummNumbers(M, (N + 1));
}

SummNumbers(M, N);
Console.WriteLine($"Сумма элементов от {M} до {N} = " + SummNumbers(M, N));