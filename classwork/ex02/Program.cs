// Найти сумму чисел от 1 до А
Console.Write("Введите число A ");
int a = int.Parse(Console.ReadLine());
int curent_digit = 1;
int curent_sum = 0;
while (curent_digit <= a)
{
	curent_sum = curent_digit+curent_sum;
	curent_digit++;

}
Console.WriteLine($"сумма всех чисел от 1 до А  = {curent_sum}");