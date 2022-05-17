// Показать таблицу квадратов чисел от 1 до N
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
int curent_digit = 1;
while (curent_digit <= n)
{
	Console.Write($"квадрат {curent_digit} равен  {Math.Pow(curent_digit, 2)} , ");
	curent_digit++;
}

// // Показать таблицу квадратов чисел от 1 до N
// Console.WriteLine("Введите число n: ");
// int n = int.Parse(Console.ReadLine());
// for (int i = 1; i <=n; i++)
// {
// Console.Write($"{i * i} ");
// }