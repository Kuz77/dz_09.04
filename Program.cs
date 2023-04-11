

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
        
Console.WriteLine("Чётные числа от 1 до {0}:", n);
for (int i = 2; i <= n; i += 2)
{
    Console.WriteLine(i);
}