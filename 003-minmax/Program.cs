int min=30000;
int n=Convert.ToInt32(Console.ReadLine());
for (int i=0;i<n;i++)
{
int a=Convert.ToInt32(Console.ReadLine());
if (a<min && a%10==4) min=n;
}
System.Console.WriteLine(min);