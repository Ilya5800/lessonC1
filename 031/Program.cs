//31. сгенерировать 10 слуайныз чисел. показать кубы тех 
//чисел которые заканчиваются на четную цифру

/*
int r = 10;
double t=r;// не явное приведение типов
double x=23;
int o=Convert.ToInt32(X)
int j=(int)x;//явное приведение типов
*/
bool Test(int a)
{
   // if (a%2==0) return true; else return false;
    return a%2==0;
}

Random random= new Random(10);
for(int i=0;i<20;i++)
{
    int a=random.Next(1,100);
    int b=a;//Math.Pow(a,3);
    if (Test(b))
       System.Console.WriteLine($"{a}, {b}");
}
    
