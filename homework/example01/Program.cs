// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int digit = 0;
for (int a = 1; a <= n; a++)
{
	digit = a * a;
	Console.WriteLine($"Квадрат числа {a} = {digit}");
}
