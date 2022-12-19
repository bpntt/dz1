Console.WriteLine("Write your number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your number 2");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{  
Console.WriteLine($"число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"число {b} больше числа {a}");
}