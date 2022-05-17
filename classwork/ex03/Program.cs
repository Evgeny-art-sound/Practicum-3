// Определить количество цифр в числе
Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
int digit = 0;
while (a>0)
{
a = a/10;
digit ++;
}
Console.WriteLine($"Количество цифр в числе: {digit}");