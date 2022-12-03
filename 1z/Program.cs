Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n1 > n2)
{
    max = n1;
    Console.WriteLine($"max = {max}");
}
else
{
    max = n2;
    Console.WriteLine($"max = {max}");
}
