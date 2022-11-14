// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество чисел ");
int N = Convert.ToInt32(Console.ReadLine());

void SummNumbers(int num1, int num2, int N)
{
    if (N <= 1) Console.Write($", {num1 + num2}");
    else
    {
        Console.Write($", {num1 + num2}");
        SummNumbers(num2, num1 + num2, N - 1);
    }
}


Console.Write($"{num1}, {num2}");
SummNumbers(num1, num2, N);

