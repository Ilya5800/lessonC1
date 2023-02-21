//int a=10;
//int b=15;
/*int k=0;
int GCD(int a, int b)
{ 
while(a!=b)
{ 
k++;
   if (a>b)
   a=a-b;
   else
   b=b-a;
}
return a;
}
   System.Console.WriteLine(GCD(15,2000));
   System.Console.WriteLine(k);
   */

   //euqlid quike
    int k=0;
   int QuickGCD(int a, int b)
   {
     while(a!=0 && b!=0)
     {
        k++;
        if (a>b)
        a=a%b;
        else
        b=b%a;
     }
return a+b;

   }
   System.Console.WriteLine(QuickGCD(15,2000));
   System.Console.WriteLine(k);