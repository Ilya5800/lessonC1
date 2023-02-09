//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 & y>0)
{
System.Console.WriteLine("Second");
}
if (x<0 & y>0)
{
    System.Console.WriteLine("First");
}
if (x>0 & y<0){
    System.Console.WriteLine("three");
}
 if (x<0 & y<0)
 {
    System.Console.WriteLine("four");
 }
 if (x==0 || y==0) System.Console.WriteLine("Error");