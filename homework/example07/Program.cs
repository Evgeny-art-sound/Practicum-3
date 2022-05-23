// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = new int[8];
Random rand = new Random();
Console.WriteLine($"Рандомный массив состит из 8 элементов содержит: ");
for (int a = 0; a < 8; a++)
{
	array[a] = rand.Next(0,2);
	Console.Write($"{array[a]} ");
}
