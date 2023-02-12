int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());

for (int j=1; j<=B-1; j++)
{
    int g = A;
 for (int i=1;i<=B-1;i++)
 {
   g=g*A;
}
    
  System.Console.WriteLine(g);
}
