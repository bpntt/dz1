Console.WriteLine("Write your number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your number 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your number 3");
int c = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;
if (a>b)
{
    max1 = a;
}
else
{
    max1 = b;
}
if  (b>c)
{
    max2 = b;
}
else
{
    max2 = c;
}
if (max1>max2)
{  
Console.WriteLine(max1);
}
else
{
    Console.WriteLine(max2);
}
