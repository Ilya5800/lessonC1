int N=Convert.ToInt32(Console.ReadLine());
int i=-N;
while(i<=N)
{
    Console.Write($"{i} ");
    i=i+1;
}
System.Console.WriteLine();
for(int j=2;j<=N;j=j+2)
{
    Console.Write($"{j} ");
}


