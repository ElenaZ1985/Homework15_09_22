Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

int[] numbers = { a, b };

int min = numbers.Min();
int max = numbers.Max();
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Max: {max}");
