// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру в рандомном массиве ");
int[] array = new int[5];
Random rand = new Random();
Console.WriteLine($"Рандомный массив состит из: ");
for (int a = 0; a < 5; a++)
{
	array[a] = rand.Next(-1000, 1000);
	Console.Write($"{array[a]} ");
	if (array[a] % 2 == 0)
	{
		Console.WriteLine($"Число четное, его куб =  {Math.Pow(array[a], 3)}");
	}
	else if (array[a] % 2 != 0)
		{
			Console.WriteLine("Число не четное ");
		}
	
}
