// Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень, в которую нужно возвести число: ");
int b = int.Parse(Console.ReadLine());
int result = a;
for (int i = 1; i < b; i++)
{
	result = result * a;
}
Console.WriteLine($"Число {a} в степени {b} = {result} ");