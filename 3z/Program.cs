Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
    {
        Console.WriteLine($"{n} является чётным числом");
    }
else
{
    Console.WriteLine($"{n} не является чётным числом");
}
