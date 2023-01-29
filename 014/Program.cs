System.Console.WriteLine("Введите число а");
int a= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
/*int c = (a/b%10000000);
System.Console.WriteLine(c);
*/

if(a%b==0)
System.Console.WriteLine("{0} - кратно b.", a%b);
if(a%b>0) 
System.Console.WriteLine(a/b%10000);

