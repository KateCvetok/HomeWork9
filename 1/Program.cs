// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1, int num2)
{

    if (num1 == num2)
    {
        Console.Write($"{num1} ");
    }
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }

}

NaturalNumbers(num1, num2);
