// Написать программу возведения числа А в целую стень B

Console.WriteLine("Введите первое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Power (int a, int b)
{
if (b == 0) return 1;
return a * Power (a, b-1);
}

int result = Power(num1, num2);
Console.WriteLine(result);

