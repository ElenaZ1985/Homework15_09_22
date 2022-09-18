//  Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите положительное число");
int num = int.Parse(Console.ReadLine());

int count =2;

while (count <= num)
{
    Console.WriteLine($"{count}");
    count = count + 2;
}    
