// Подсчитать сумму цифр в числе
Random rnd = new Random();
int x = rnd.Next(0,100000);
Console.WriteLine($" рандомное число = {x}");
int sum = 0;
while(x > 0)
{
    sum = sum + x % 10;
    x = x / 10;
}
Console.WriteLine($" сумма чисел в рандомном числе = {sum} ");
