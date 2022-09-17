// 
Console.WriteLine("Введите число A");
string input = Console.ReadLine();
int a = int.Parse(input);
Console.WriteLine("Введите число B");
string input2 = Console.ReadLine();
int b = int.Parse(input2);
int max = 0;
int min = 0;
{
if (a > b) max = a;
if (a > b) min = b;
if (b > a) max = b;
if (b > a) min = a;
}
Console.WriteLine("Большее числа =");
Console.WriteLine(max);
Console.WriteLine("Меньшее число =");
Console.WriteLine(min);
