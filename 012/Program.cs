System.Console.WriteLine("Введите число");

int a= Convert.ToInt32(Console.ReadLine());
int b = a/1%10;
int c = a/10%100;

int max = b;
if (c>b) max = c;
System.Console.WriteLine(max );