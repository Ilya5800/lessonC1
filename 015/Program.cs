
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());


//345
//12345
int b=a/100%10;
if (b==0)
{
System.Console.WriteLine("No");
}
else
{
if (b>0)
System.Console.WriteLine(b);
}
