// Найти кубы чисел от 1 до N
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int digit = 0;
for (int a = 1; a <= n; a++)
{
	Console.WriteLine($"куб числа {a} = {Math.Pow(a,3)}");
}

