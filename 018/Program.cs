System.Console.WriteLine("Введи число 1");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи число 2");
int b = Convert.ToInt32(Console.ReadLine());
int c = (a*a);

if (a<b)
{
    c=(a*a);
    if ((a*a)==b)
    {
        System.Console.WriteLine("Yes");
    }
}
else
{
      c=(b*b);
    if ((b*b)==a)
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("no");
    }
    }


