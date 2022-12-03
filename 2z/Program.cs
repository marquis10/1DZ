Console.Clear();
Console.Write("Введите число1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int m = 0;
if (n1 > n2)
{
    m = n1;
    if (m > n3)
    {
        Console.WriteLine($"max = {m}");
    }
    else
    {
        Console.WriteLine($"max = {n3}");
    }
}
else
{
    m = n2;
    if (m > n3)
    {
            Console.WriteLine($"max = {m}");
    }
    else
    {
        Console.WriteLine($"max = {n3}");
    }
}
