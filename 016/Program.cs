System.Console.WriteLine("Введите число а");
int a= Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число b");
//int b = Convert.ToInt32(Console.ReadLine());
/*int c = (a/b%10000000);
System.Console.WriteLine(c);
*/

if(a%7==0)
System.Console.WriteLine("{0} - кратно 7.", a%7);
if(a%7>0) 
System.Console.WriteLine("Не кратно");
if(a%23==0)
System.Console.WriteLine("{0} - кратно 23.", a%23);
if(a%23>0) 
System.Console.WriteLine("Не кратно");
