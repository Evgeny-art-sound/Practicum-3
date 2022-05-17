// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int digit = 1;
int temp = 1;
while (digit <= n)
{
	temp = temp * digit;
	digit++;
}
Console.WriteLine($"Произведение чисел от 1 до {n} = {temp}");