// Найти сумму чисел от 1 до А
Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine());
int digit = 0;
for (int a = 0; a <= n; a++)
{
	digit = digit + a;
}
Console.WriteLine($"Сумма чисел от 1 до N = {digit}");